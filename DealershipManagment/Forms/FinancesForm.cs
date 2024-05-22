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
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
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
        }

        private void UpdateDgv()
        {
            dt.Clear();
            var finances = db.Reports
                .Include(x => x.Worker)
                .ToList();
            foreach (var f in finances)
            {
                DataRow dataRow = dt.NewRow();
                dataRow[0] = f.MonthReport;
                dataRow[1] = f.HoursWork;
                dataRow[2] = f.Salary;
                dataRow[3] = f.Prize;
                dataRow[4] = f.Worker.Fio;
                dataRow[5] = f.DateReport;
                dt.Rows.Add(dataRow);
            }
            financesDgv.DataSource = dt;
        }

        private void FinancesForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
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
                Show();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            AddEditReportsForm editReport = new AddEditReportsForm(Guid.Parse(financesDgv[6, financesDgv.SelectedRows[0].Index].Value.ToString()));
            Hide();
            if (editReport.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
                Show();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этот отчёт?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Reports.Remove(db.Reports.FirstOrDefault(x => x.IdReport == Guid.Parse(financesDgv[6,
                    financesDgv.SelectedRows[0].Index].Value.ToString())));
                db.SaveChanges();
                UpdateDgv();
            }
        }
    }
}
