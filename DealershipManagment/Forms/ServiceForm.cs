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
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
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
        }

        private void UpdateDgv()
        {
            dt.Clear();
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
                dt.Rows.Add(dataRow);
            }
            serviceDgv.DataSource = dt;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }
    }
}
