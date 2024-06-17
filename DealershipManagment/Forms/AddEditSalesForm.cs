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
    public partial class AddEditSalesForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
        Guid saleId = Guid.Empty;
        List<Car> cars = null;
        public AddEditSalesForm()
        {
            InitializeComponent();
            Text = "Добавить";
            addEditBtn.Text = "Добавить";
        }
        public AddEditSalesForm(Guid i)
        {
            InitializeComponent();
            Text = "Изменить";
            addEditBtn.Text = "Изменить";
            saleId = i;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            var sale = new Sale();
            if (addEditBtn.Text == "Изменить")
            {
                sale = db.Sales.FirstOrDefault(x=>x.IdSale== saleId);
            }
            if (decimal.TryParse(priceTxt.Text,out decimal d))
            {
                sale.CarId = db.Cars.FirstOrDefault(x => x.IdCar == cars[carsCmb.SelectedIndex].IdCar).IdCar;
                sale.Total = decimal.Parse(priceTxt.Text);
                sale.ClientId = db.Clients.FirstOrDefault(x => x.Fio == clientCmb.SelectedItem).IdClient;
                sale.WorkerId = db.Workers.FirstOrDefault(x => x.Fio == workerCmb.SelectedItem).IdWorker;
                sale.Notes = notesTxt.Text;
                if (addEditBtn.Text == "Добавить")
                {
                    sale.IdSale = Guid.NewGuid();
                    sale.DateSale = DateTime.Now;
                    db.Sales.Add(sale);
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

        private void AddEditSalesForm_Load(object sender, EventArgs e)
        {
            cars = db.Cars.Include(x => x.Mark).ToList();
            carsCmb.Items.Clear();
            clientCmb.Items.Clear();
            workerCmb.Items.Clear();
            foreach (var item in db.Cars.Include(x=>x.Mark).ToList())
            {
                 carsCmb.Items.Add($"{item.Mark.NameMark} {item.Model}");
            }
            foreach (var item in db.Clients.ToList())
            {
                clientCmb.Items.Add($"{item.Fio}");
            }
            foreach (var item in db.Workers.ToList())
            {
                if (item.Status != 2 && item.RoleId == 2)
                {
                    workerCmb.Items.Add($"{item.Fio}");
                }
            }
            carsCmb.SelectedIndex = 0;
            clientCmb.SelectedIndex = 0;
            workerCmb.SelectedIndex = 0;
            if (Text == "Изменить")
            {
                var sale = db.Sales
                    .Include(x => x.Car)
                    .Include(x => x.Worker)
                    .Include(x => x.Client)
                    .FirstOrDefault(x => x.IdSale == saleId);
                carsCmb.SelectedIndex = cars.IndexOf(db.Cars.FirstOrDefault(x=>x.IdCar==sale.CarId));
                priceTxt.Text = sale.Total.ToString();
                clientCmb.SelectedItem = sale.Client.Fio;
                workerCmb.SelectedItem = sale.Worker.Fio;
                notesTxt.Text = sale.Notes;
            }
        }
    }
}