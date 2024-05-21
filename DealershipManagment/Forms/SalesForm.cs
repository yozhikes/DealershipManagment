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
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
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
        }

        private void UpdateDgv()
        {
            dt.Clear();
            var sales = db.Sales
                .Include(x => x.Worker)
                .Include(x => x.Car)
                .Include(x => x.Client)
                .Include(x=>x.Car.Mark)
                .ToList();
            foreach (var s in sales)
            {
                DataRow dataRow = dt.NewRow();
                dataRow[0] = $"{s.Car.Mark.NameMark} {s.Car.Model}";
                dataRow[1] = s.Client.Fio;
                dataRow[2] = s.Worker.Fio;
                dataRow[3] = s.Total;
                dataRow[4] = s.Notes;
                dataRow[5] = s.DateSale;
                dt.Rows.Add(dataRow);
            }
            salesDgv.DataSource = dt;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }
    }
}
