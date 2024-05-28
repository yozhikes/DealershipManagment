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
    public partial class SalesForm : Form
    {
        DataTable dt = new DataTable();
        public SalesForm()
        {
            InitializeComponent();
            salesDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            salesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt.Columns.Add("Машина");
            dt.Columns.Add("Клиент");
            dt.Columns.Add("Менеджер");
            dt.Columns.Add("Итого");
            dt.Columns.Add("Примечания");
            dt.Columns.Add("Дата продажи");
            dt.Columns.Add("idSale");
            using (DbDealershipManagmentContext db = new DbDealershipManagmentContext())
            {
                filterCmb.DataSource = db.Sales.Include(x=>x.Worker).Select(x => x.Worker.Fio).Distinct().ToList();
            }
        }

        private void UpdateDgv()
        {
            dt.Clear();
            using (var db = new DbDealershipManagmentContext())
            {
                var sales = db.Sales
                .Include(x => x.Worker)
                .Include(x => x.Car)
                .Include(x => x.Client)
                .Include(x => x.Car.Mark)
                .ToList();
                foreach (var s in sales)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow[0] = $"{s.Car.Mark.NameMark} {s.Car.Model}";
                    dataRow[1] = s.Client.Fio;
                    dataRow[2] = s.Worker.Fio;
                    dataRow[3] = s.Total.ToString("G29");
                    dataRow[4] = s.Notes;
                    dataRow[5] = s.DateSale;
                    dataRow[6] = s.IdSale;
                    dt.Rows.Add(dataRow);
                }
            }
            salesDgv.DataSource = dt;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            salesDgv.Columns[6].Visible = false;
            salesDgv.Sort(salesDgv.Columns[6], ListSortDirection.Ascending);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditSalesForm addSale = new AddEditSalesForm();
            Hide();
            if (addSale.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            AddEditSalesForm editSale = new AddEditSalesForm(Guid.Parse(salesDgv[6, salesDgv.SelectedRows[0].Index].Value.ToString()));
            Hide();
            if (editSale.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
            Show();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту машину?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new DbDealershipManagmentContext())
                {
                    db.Sales.Remove(db.Sales.FirstOrDefault(x => x.IdSale == Guid.Parse(salesDgv[6,
                    salesDgv.SelectedRows[0].Index].Value.ToString())));
                    db.SaveChanges();
                }
                UpdateDgv();
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
                if (dt.Rows[i][2].ToString() != filterCmb.Text)
                {
                    dt.Rows.Remove(dt.Rows[i]);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            salesDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= salesDgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= salesDgv.ColumnCount - 2; j++)
                    {
                        if (salesDgv.Rows[i].Cells[j].Value != null && salesDgv.Rows[i].Cells[j].Value.ToString()
                            .ToUpper().Contains(searchTxt.Text.ToUpper()))
                        {
                            salesDgv.Rows[i].Cells[j].Selected = true;
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
    }
}
