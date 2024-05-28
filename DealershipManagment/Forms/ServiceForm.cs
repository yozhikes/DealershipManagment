using DealershipManagment.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealershipManagment
{
    public partial class ServiceForm : Form
    {
        DataTable dt = new DataTable();
        public ServiceForm()
        {
            InitializeComponent();
            serviceDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            serviceDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt.Columns.Add("Машина");
            dt.Columns.Add("Статус");
            dt.Columns.Add("Примечания");
            dt.Columns.Add("Дата начала починки");
            dt.Columns.Add("Дата окончания починки");
            dt.Columns.Add("Цена ремонта");
            dt.Columns.Add("idService");
            foreach (var item in Enum.GetValues(typeof(StatusesRequest)))
            {
                filterCmb.Items.Add(item.ToString());
                statusCmb.Items.Add(item.ToString());
            }
            filterCmb.SelectedIndex = 0;
            statusCmb.SelectedIndex = 0;
        }

        private void UpdateDgv()
        {
            dt.Clear();
            using (var db = new DbDealershipManagmentContext())
            {
                var services = db.Requests
                .Include(x => x.Car)
                .Include(x => x.Car.Mark)
                .ToList();
                foreach (var s in services)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow[0] = $"{s.Car.Mark.NameMark} {s.Car.Model}";
                    switch (s.StatusZayavki)
                    {
                        case 0:
                            dataRow[1] = StatusesRequest.Обработка;
                            break;
                        case 1:
                            dataRow[1] = StatusesRequest.Ремонт;
                            break;
                        case 2:
                            dataRow[1] = StatusesRequest.Готово;
                            break;
                    }
                    dataRow[2] = s.Notes;
                    dataRow[3] = s.DateStartRepair;
                    dataRow[4] = s.DateEndRepair;
                    dataRow[5] = s.Price?.ToString("G29");
                    dataRow[6] = s.IdRequest;
                    dt.Rows.Add(dataRow);
                }
            }
            serviceDgv.DataSource = dt;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            serviceDgv.Columns[6].Visible = false;
            serviceDgv.Sort(serviceDgv.Columns[6], ListSortDirection.Ascending);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditRequestsForm addRequest = new AddEditRequestsForm();
            Hide();
            if (addRequest.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (serviceDgv.SelectedRows.Count == 1)
            {
                AddEditRequestsForm editRequest = new AddEditRequestsForm(Guid.Parse(serviceDgv[6, serviceDgv.SelectedRows[0].Index].Value.ToString()));
                Hide();
                if (editRequest.ShowDialog() == DialogResult.OK)
                {
                    UpdateDgv();
                }
                Show();
            }
            else if (serviceDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (serviceDgv.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Вы действительно хотите удалить этот запрос?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new DbDealershipManagmentContext())
                    {
                        db.Requests.Remove(db.Requests.FirstOrDefault(x => x.IdRequest == Guid.Parse(serviceDgv[6,
                        serviceDgv.SelectedRows[0].Index].Value.ToString())));
                        db.SaveChanges();
                    }
                    UpdateDgv();
                }
            }
            else if (serviceDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            if (serviceDgv.SelectedRows.Count == 1)
            {
                using (var db = new DbDealershipManagmentContext())
                {
                    var service = db.Requests.FirstOrDefault(x => x.IdRequest ==
                Guid.Parse(serviceDgv[6, serviceDgv.SelectedRows[0].Index].Value.ToString()));
                    service.StatusZayavki = statusCmb.SelectedIndex;
                    switch (statusCmb.SelectedIndex)
                    {
                        case 1:
                            service.DateStartRepair = DateTime.Now;
                            break;
                        case 2:
                            service.DateEndRepair = DateTime.Now;
                            break;
                    }
                    db.SaveChanges();
                }
                UpdateDgv();
            }
            else if (serviceDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void clrFltrBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i][1].ToString() != filterCmb.Text)
                {
                    dt.Rows.Remove(dt.Rows[i]);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            serviceDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= serviceDgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= serviceDgv.ColumnCount - 2; j++)
                    {
                        if (serviceDgv.Rows[i].Cells[j].Value != null && serviceDgv.Rows[i].Cells[j].Value
                            .ToString().ToUpper().Contains(searchTxt.Text.ToUpper()))
                        {
                            serviceDgv.Rows[i].Cells[j].Selected = true;
                            quantity++;
                        }
                    }
                }
                if (quantity != 0)
                {
                    MessageBox.Show($"Найдено {quantity} совпадений", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пустое поле ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void serviceDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusCmb.SelectedItem = serviceDgv.Rows[serviceDgv.SelectedRows[0].Index].Cells[1].Value;
        }

        private void serviceDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            statusCmb.SelectedItem = serviceDgv.Rows[serviceDgv.SelectedRows[0].Index].Cells[1].Value;
        }
    }
}
