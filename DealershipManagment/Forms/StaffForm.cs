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
    public partial class StaffForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
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
            dt.Columns.Add("Логин");
            dt.Columns.Add("Пароль");
        }

        private void UpdateDgv()
        {
            dt.Clear();
            var staff = db.Workers
                .Include(x => x.Role)
                .ToList();
            foreach (var s in staff)
            {
                DataRow dataRow = dt.NewRow();
                dataRow[0] = s.Fio;
                dataRow[1] = s.Pass;
                dataRow[2] = s.TelNum;
                dataRow[3] = s.Role.NameRole;
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
                dataRow[5] = s.Login;
                dataRow[6] = s.Password;
                dt.Rows.Add(dataRow);
            }
            staffDgv.DataSource = dt;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }
    }
}
