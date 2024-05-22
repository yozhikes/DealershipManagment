using DealershipManagment.Enums;
using DealershipManagment.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DealershipManagment
{
    public partial class AddEditCarsForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
        Guid carId = Guid.Empty;
        public AddEditCarsForm()
        {
            InitializeComponent();
            Text = "Добавить";
            addEditBtn.Text = "Добавить";
        }

        public AddEditCarsForm(Guid i)
        {
            InitializeComponent();
            Text = "Изменить";
            addEditBtn.Text = "Изменить";
            carId = i;
        }

        private void AddEditCarsForm_Load(object sender, EventArgs e)
        {
            marksCmb.DataSource = db.Marks.Select(x => x.NameMark).ToList();
            driveCmb.Items.Clear();
            transmissionCmb.Items.Clear();
            bodyCmb.Items.Clear();
            engineCmb.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Drives)))
            {
                driveCmb.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Transmissions)))
            {
                transmissionCmb.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(BodyTypes)))
            {
                bodyCmb.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(EngineTypes)))
            {
                engineCmb.Items.Add(item);
            }
            if (Text == "Изменить")
            {
                var car = db.Cars.Include(x => x.Mark).FirstOrDefault(x => x.IdCar == carId);
                modelTxt.Text = car.Model;
                yearTxt.Text = car.ReleaseYear.ToString();
                vinTxt.Text = car.Vin;
                priceTxt.Text = car.Price.ToString();
                notesTxt.Text = car.Notes;
                marksCmb.SelectedItem = car.Mark.NameMark;
                driveCmb.SelectedIndex = car.Drive;
                transmissionCmb.SelectedIndex = car.Transmission;
                bodyCmb.SelectedIndex = car.BodyType;
                engineCmb.SelectedIndex = car.EngineType;
            }
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            var car = new Car();
            if (addEditBtn.Text == "Изменить")
            {
                car = db.Cars.FirstOrDefault(x => x.IdCar == carId);
            }
            car.MarkId = db.Marks.FirstOrDefault(x => x.NameMark == marksCmb.Text).IdMark;
            car.Model = modelTxt.Text;
            car.Drive = driveCmb.SelectedIndex;
            car.Transmission = transmissionCmb.SelectedIndex;
            car.BodyType = bodyCmb.SelectedIndex;
            car.EngineType = engineCmb.SelectedIndex;
            car.ReleaseYear = int.Parse(yearTxt.Text);
            car.Vin = vinTxt.Text;
            car.Price = decimal.Parse(priceTxt.Text);
            car.Notes = notesTxt.Text;
            if(addEditBtn.Text == "Добавить")
            {
                car.IdCar = Guid.NewGuid();
                car.Status = 0;
                db.Cars.Add(car);
            }
            DialogResult = DialogResult.OK;
            db.SaveChanges();
            MessageBox.Show("Данные внесены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
