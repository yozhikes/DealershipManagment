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
            monthCmb.Items.Clear();
            monthCmb.Items.Add("Январь " +  DateTime.Now.Year);
            monthCmb.Items.Add("Февраль " +  DateTime.Now.Year);
            monthCmb.Items.Add("Март " +  DateTime.Now.Year);
            monthCmb.Items.Add("Апрель " +  DateTime.Now.Year);
            monthCmb.Items.Add("Май " +  DateTime.Now.Year);
            monthCmb.Items.Add("Июнь " +  DateTime.Now.Year);
            monthCmb.Items.Add("Июль " +  DateTime.Now.Year);
            monthCmb.Items.Add("Август " +  DateTime.Now.Year);
            monthCmb.Items.Add("Сентябрь " +  DateTime.Now.Year);
            monthCmb.Items.Add("Октябрь " +  DateTime.Now.Year);
            monthCmb.Items.Add("Ноябрь " +  DateTime.Now.Year);
            monthCmb.Items.Add("Декабрь " +  DateTime.Now.Year);
            foreach (var item in db.Workers.ToList())
            {
                if (item.Status != 2)
                {
                    workersCmb.Items.Add($"{item.Fio}");
                }
            }
            monthCmb.SelectedIndex = 0;
            workersCmb.SelectedIndex = 0;
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
                report = db.Reports.Include(x => x.Worker).FirstOrDefault(x => x.IdReport == reportId);
            }
            if (decimal.TryParse(salaryTxt.Text,out decimal d)&& decimal.TryParse(prizeTxt.Text, out decimal f))
            {
                report.Salary = decimal.Parse(salaryTxt.Text);
                report.HoursWork = int.Parse(hoursTxt.Value.ToString());
                report.MonthReport = monthCmb.Text;
                report.Prize = decimal.Parse(prizeTxt.Text);
                report.WorkerId = db.Workers.FirstOrDefault(x => x.Fio == workersCmb.Text).IdWorker;
                report.DateReport = DateTime.Now;
                if (addEditBtn.Text == "Добавить")
                {
                    report.IdReport = Guid.NewGuid();
                    db.Reports.Add(report);
                }
                DialogResult = DialogResult.OK;
                db.SaveChanges();
                MessageBox.Show("Данные внесены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
