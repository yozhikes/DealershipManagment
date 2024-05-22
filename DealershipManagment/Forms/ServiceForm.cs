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
            serviceDgv.Columns[5].Visible = false;
            serviceDgv.Sort(serviceDgv.Columns[5], ListSortDirection.Ascending);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditRequestsForm addRequest = new AddEditRequestsForm();
            Hide();
            if (addRequest.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
                Show();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            AddEditRequestsForm editRequest = new AddEditRequestsForm(Guid.Parse(serviceDgv[5, serviceDgv.SelectedRows[0].Index].Value.ToString()));
            Hide();
            if (editRequest.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
                Show();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этот запрос?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Cars.Remove(db.Cars.FirstOrDefault(x => x.IdCar == Guid.Parse(serviceDgv[5,
                    serviceDgv.SelectedRows[0].Index].Value.ToString())));
                db.SaveChanges();
                UpdateDgv();
            }
        }
    }
}
