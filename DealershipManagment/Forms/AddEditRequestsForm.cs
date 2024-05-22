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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DealershipManagment
{
    public partial class AddEditRequestsForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
        Guid requestId = Guid.Empty;
        public AddEditRequestsForm()
        {
            InitializeComponent();
            Text = "Добавить";
            addEditBtn.Text = "Добавить";
        }

        public AddEditRequestsForm(Guid i)
        {
            InitializeComponent();
            Text = "Изменить";
            addEditBtn.Text = "Изменить";
            requestId = i;
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            var req = new Request();
            if (addEditBtn.Text == "Изменить")
            {
                req = db.Requests.FirstOrDefault(x => x.IdRequest == requestId);
            }
            req.CarId = db.Cars.FirstOrDefault(x => x.Model == carsCmb.Text).IdCar;
            req.StatusZayavki = statusCmb.SelectedIndex;
            req.Notes = notesTxt.Text;
            if (addEditBtn.Text == "Добавить")
            {
                req.IdRequest = Guid.NewGuid();
                req.StatusZayavki = 0;
                db.Requests.Add(req);
            }
            DialogResult = DialogResult.OK;
            db.SaveChanges();
            MessageBox.Show("Данные внесены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddEditRequestsForm_Load(object sender, EventArgs e)
        {
            statusCmb.DataSource = db.Cars.Include(x => x.Mark).Select(x => x.Model).ToList();
            statusCmb.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(StatusesRequest)))
            {
                statusCmb.Items.Add(item);
            }
            if (Text == "Изменить")
            {
                var req = db.Requests.Include(x => x.Car).FirstOrDefault(x => x.IdRequest == requestId);
                carsCmb.SelectedValue = req.Car.Model;
                statusCmb.SelectedIndex = req.StatusZayavki;
                notesTxt.Text = req.Notes;
            }
        }
    }
}
