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
    public partial class FinancesForm : Form
    {
        DataTable dt = new DataTable();
        public FinancesForm()
        {
            InitializeComponent();
            financesDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            financesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt.Columns.Add("Месяц");
            dt.Columns.Add("Часы работы");
            dt.Columns.Add("Зарплата");
            dt.Columns.Add("Премия");
            dt.Columns.Add("Сотрудник");
            dt.Columns.Add("Дата отчёта");
            dt.Columns.Add("idFinance");
            using (DbDealershipManagmentContext db = new DbDealershipManagmentContext())
            {
                filterCmb.DataSource = db.Reports.Select(x => x.HoursWork).Distinct().ToList();
            }
            filterCmb.SelectedIndex = 0;
        }

        private void UpdateDgv()
        {
            dt.Clear();
            using (var db = new DbDealershipManagmentContext())
            {
                var finances = db.Reports
                .Include(x => x.Worker)
                .ToList();
                foreach (var f in finances)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow[0] = f.MonthReport;
                    dataRow[1] = f.HoursWork;
                    dataRow[2] = f.Salary.ToString("G29");
                    dataRow[3] = f.Prize.ToString("G29");
                    dataRow[4] = f.Worker.Fio;
                    dataRow[5] = f.DateReport;
                    dataRow[6] = f.IdReport;
                    dt.Rows.Add(dataRow);
                }
            }
            financesDgv.DataSource = dt;
        }

        private void FinancesForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            filterCmb.SelectedIndex = 0;
            financesDgv.Columns[6].Visible = false;
            financesDgv.Sort(financesDgv.Columns[6], ListSortDirection.Ascending);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditReportsForm addReport = new AddEditReportsForm();
            Hide();
            if (addReport.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
                using (var db = new DbDealershipManagmentContext())
                {
                    filterCmb.DataSource = db.Reports.Select(x => x.HoursWork).Distinct().ToList();
                }
            }
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (financesDgv.SelectedRows.Count == 1)
            {
                AddEditReportsForm editReport = new AddEditReportsForm(Guid.Parse(financesDgv[6, financesDgv.SelectedRows[0].Index].Value.ToString()));
                Hide();
                if (editReport.ShowDialog() == DialogResult.OK)
                {
                    UpdateDgv();
                    using (var db = new DbDealershipManagmentContext())
                    {
                        filterCmb.DataSource = db.Reports.Select(x => x.HoursWork).Distinct().ToList();
                    }
                }
                Show();
            }
            else if (financesDgv.SelectedRows.Count > 1)
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
            if (financesDgv.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Вы действительно хотите удалить этот отчёт?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new DbDealershipManagmentContext())
                    {
                        db.Reports.Remove(db.Reports.FirstOrDefault(x => x.IdReport == Guid.Parse(financesDgv[6,
                        financesDgv.SelectedRows[0].Index].Value.ToString())));
                        db.SaveChanges();
                        filterCmb.DataSource = db.Reports.Select(x => x.HoursWork).Distinct().ToList();
                    }
                    UpdateDgv();
                }
            }
            else if (financesDgv.SelectedRows.Count > 1)
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
            financesDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= financesDgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= financesDgv.ColumnCount - 2; j++)
                    {
                        if (financesDgv.Rows[i].Cells[j].Value != null && financesDgv.Rows[i].Cells[j].Value.ToString()
                            .ToUpper().Contains(searchTxt.Text.ToUpper()))
                        {
                            financesDgv.Rows[i].Cells[j].Selected = true;
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
