using DealershipManagment.Enums;
using DealershipManagment.Tables;
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
    public partial class AddEditReportsForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
        Guid reportId = Guid.Empty;
        public AddEditReportsForm()
        {
            InitializeComponent();
            Text = "Добавить";
            addEditBtn.Text = "Добавить";
        }

        public AddEditReportsForm(Guid i)
        {
            InitializeComponent();
            Text = "Изменить";
            addEditBtn.Text = "Изменить";
            reportId = i;
        }

        private void AddEditReportsForm_Load(object sender, EventArgs e)
        {
            workersCmb.DataSource = db.Workers.Select(x => x.Fio).ToList();
            if (Text == "Изменить")
            {
                var report = db.Reports.Include(x => x.Worker).FirstOrDefault(x => x.IdReport == reportId);
                salaryTxt.Text = report.Salary.ToString();
                hoursTxt.Text = report.HoursWork.ToString();
                monthCmb.SelectedItem = report.MonthReport;
                prizeTxt.Text = report.Prize.ToString();
                workersCmb.SelectedItem = report.Worker.Fio;
            }
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            var report = new Report();
            if (addEditBtn.Text == "Изменить")
            {
                report = db.Reports.FirstOrDefault(x => x.IdReport == reportId);
            }
            report.Salary = decimal.Parse(salaryTxt.Text);
            report.HoursWork = int.Parse(hoursTxt.Value.ToString());
            report.MonthReport = monthCmb.Text;
            report.Prize = int.Parse(prizeTxt.Text);
            report.WorkerId = db.Workers.FirstOrDefault(x => x.Fio == workersCmb.Text).IdWorker;
            if (addEditBtn.Text == "Добавить")
            {
                report.IdReport = Guid.NewGuid();
                report.DateReport = DateOnly.FromDateTime(DateTime.Now);
                db.Reports.Add(report);
            }
            DialogResult = DialogResult.OK;
            db.SaveChanges();
            MessageBox.Show("Данные внесены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
