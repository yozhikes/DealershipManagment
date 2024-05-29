using DealershipManagment.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealershipManagment
{
    public partial class StaffForm : Form
    {
        DataTable dt = new DataTable();
        public StaffForm()
        {
            InitializeComponent();
            staffDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            staffDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Пасспорт");
            dt.Columns.Add("Номер телефона");
            dt.Columns.Add("Роль");
            dt.Columns.Add("Статус");
            dt.Columns.Add("idWorker");
            foreach (var item in Enum.GetValues(typeof(StatusesWorkers)))
            {
                filterCmb.Items.Add(item.ToString());
                statusCmb.Items.Add(item.ToString());
            }
            filterCmb.SelectedIndex = 0;
        }

        private void UpdateDgv()
        {
            dt.Clear();
            using (DbDealershipManagmentContext db = new DbDealershipManagmentContext())
            {
                var staff = db.Workers
                .ToList();
                foreach (var s in staff)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow[0] = s.Fio;
                    dataRow[1] = s.Pass;
                    dataRow[2] = s.TelNum;
                    dataRow[3] = (Roles)s.RoleId;
                    switch (s.Status)
                    {
                        case 0:
                            dataRow[4] = StatusesWorkers.Стажировка;
                            break;
                        case 1:
                            dataRow[4] = StatusesWorkers.Работает;
                            break;
                        case 2:
                            dataRow[4] = StatusesWorkers.Уволен;
                            break;
                    }
                    dataRow[5] = s.IdWorker;
                    dt.Rows.Add(dataRow);
                }
            }
            staffDgv.DataSource = dt;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            staffDgv.Columns[5].Visible = false;
            staffDgv.Sort(staffDgv.Columns[5], ListSortDirection.Ascending);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            if (staffDgv.SelectedRows.Count == 1)
            {
                using (DbDealershipManagmentContext db = new DbDealershipManagmentContext())
                {
                    var worker = db.Workers.FirstOrDefault(x => x.IdWorker == Guid.Parse(staffDgv[5, staffDgv.SelectedRows[0].Index].Value.ToString()));
                    worker.Status = statusCmb.SelectedIndex;
                    db.SaveChanges();
                }
                UpdateDgv();
            }
            else if (staffDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditWorkersForm addCar = new AddEditWorkersForm();
            Hide();
            if (addCar.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (staffDgv.SelectedRows.Count == 1)
            {
                AddEditWorkersForm editCar = new AddEditWorkersForm(Guid.Parse(staffDgv[5, staffDgv.SelectedRows[0].Index].Value.ToString()));
                Hide();
                if (editCar.ShowDialog() == DialogResult.OK)
                {
                    UpdateDgv();
                }
                Show();
            }
            else if (staffDgv.SelectedRows.Count > 1)
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
            if (staffDgv.SelectedRows.Count == 1)
            {
                using (var db = new DbDealershipManagmentContext())
                {
                    if (db.Sales.FirstOrDefault(x => x.WorkerId == Guid.Parse(staffDgv[5,
                            staffDgv.SelectedRows[0].Index].Value.ToString())) == null
                            && db.Reports.FirstOrDefault(x => x.WorkerId == Guid.Parse(staffDgv[5,
                            staffDgv.SelectedRows[0].Index].Value.ToString())) == null)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить эту машину?", "Удаление",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Workers.Remove(db.Workers.FirstOrDefault(x => x.IdWorker == Guid.Parse(staffDgv[5,
                            staffDgv.SelectedRows[0].Index].Value.ToString())));
                            db.SaveChanges();
                            UpdateDgv();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Этот клиент уже был использован!", "Невозможно удалить", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } 
            }
            else if (staffDgv.SelectedRows.Count > 1)
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
                if (dt.Rows[i][4].ToString() != filterCmb.Text)
                {
                    dt.Rows.Remove(dt.Rows[i]);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            staffDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= staffDgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= staffDgv.ColumnCount - 2; j++)
                    {
                        if (staffDgv.Rows[i].Cells[j].Value != null && staffDgv.Rows[i].Cells[j].Value.ToString()
                            .ToUpper().Contains(searchTxt.Text.ToUpper()))
                        {
                            staffDgv.Rows[i].Cells[j].Selected = true;
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

        private void staffDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            statusCmb.SelectedItem = staffDgv.Rows[staffDgv.SelectedRows[0].Index].Cells[4].Value;
        }

        private void staffDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusCmb.SelectedItem = staffDgv.Rows[staffDgv.SelectedRows[0].Index].Cells[4].Value;
        }
    }
}
