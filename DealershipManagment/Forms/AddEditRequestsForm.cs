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
        List<Car> cars = null;
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
                req = db.Requests.Include(x => x.Car).FirstOrDefault(x => x.IdRequest == requestId);
            }
            if (priceTxt.Text != string.Empty)
            {
                if(decimal.TryParse(priceTxt.Text, out decimal d))
                {
                    req.Price = decimal.Parse(priceTxt.Text);
                    req.CarId = db.Cars.FirstOrDefault(x => x.IdCar == cars[carsCmb.SelectedIndex].IdCar).IdCar;
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
                else
                {
                    MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                req.CarId = db.Cars.FirstOrDefault(x => x.IdCar == cars[carsCmb.SelectedIndex].IdCar).IdCar;
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
            
        }

        private void AddEditRequestsForm_Load(object sender, EventArgs e)
        {
            cars = db.Cars.Include(x => x.Mark).ToList();
            carsCmb.Items.Clear();
            foreach (var item in db.Cars.Include(x => x.Mark).ToList())
            {
                carsCmb.Items.Add($"{item.Mark.NameMark} {item.Model}");
            }
            carsCmb.SelectedIndex = 0;
            if (Text == "Изменить")
            {
                var req = db.Requests.Include(x => x.Car).FirstOrDefault(x => x.IdRequest == requestId);
                carsCmb.SelectedIndex = cars.IndexOf(db.Cars.FirstOrDefault(x => x.IdCar == req.CarId));
                notesTxt.Text = req.Notes;
                priceTxt.Text = req.Price.ToString();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
