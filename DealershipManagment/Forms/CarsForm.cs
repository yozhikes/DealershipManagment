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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DealershipManagment
{
    public partial class CarsForm : Form
    {
        DataTable dt = new DataTable();
        public CarsForm()
        {
            InitializeComponent();
            carsDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            carsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt.Columns.Add("Марка");
            dt.Columns.Add("Модель");
            dt.Columns.Add("Привод");
            dt.Columns.Add("Коробка передач");
            dt.Columns.Add("Тип кузова");
            dt.Columns.Add("Тип топлива");
            dt.Columns.Add("Цвет");
            dt.Columns.Add("Мощность двигателя, л.с.");
            dt.Columns.Add("Год выпуска");
            dt.Columns.Add("VIN");
            dt.Columns.Add("Цена");
            dt.Columns.Add("Примечания");
            dt.Columns.Add("Статус");
            dt.Columns.Add("idCar");
            foreach (var item in Enum.GetValues(typeof(Statuses)))
            {
                statusCmb.Items.Add(item.ToString());
                filterCmb.Items.Add(item.ToString());
            }
            statusCmb.SelectedIndex = 0;
            filterCmb.SelectedIndex = 0;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            carsDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= carsDgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= carsDgv.ColumnCount - 2; j++)
                    {
                        if (carsDgv.Rows[i].Cells[j].Value != null && carsDgv.Rows[i].Cells[j].Value.ToString()
                            .ToUpper().Contains(searchTxt.Text.ToUpper()))
                        {
                            carsDgv.Rows[i].Cells[j].Selected = true;
                            quantity++;
                        }
                    }
                }
                if (quantity != 0)
                {
                    MessageBox.Show($"Найдено {quantity} совпадений", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пустое поле ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            carsDgv.Columns[13].Visible = false;
            carsDgv.Sort(carsDgv.Columns[13], ListSortDirection.Ascending);
        }

        private void UpdateDgv()
        {
            dt.Clear();
            using (DbDealershipManagmentContext db = new DbDealershipManagmentContext())
            {
                var cars = db.Cars
                .Include(x => x.Mark)
                .ToList();

                foreach (var c in cars)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow[0] = c.Mark.NameMark;
                    dataRow[1] = c.Model;
                    switch (c.Drive)
                    {
                        case 0:
                            dataRow[2] = Drives.Передний;
                            break;
                        case 1:
                            dataRow[2] = Drives.Задний;
                            break;
                        case 2:
                            dataRow[2] = Drives.Полный;
                            break;
                    }
                    switch (c.Transmission)
                    {
                        case 0:
                            dataRow[3] = Transmissions.Механическая;
                            break;
                        case 1:
                            dataRow[3] = Transmissions.Автоматическая;
                            break;
                        case 2:
                            dataRow[3] = Transmissions.Робот;
                            break;
                        case 3:
                            dataRow[3] = Transmissions.Вариативная;
                            break;
                    }
                    switch (c.BodyType)
                    {
                        case 0:
                            dataRow[4] = BodyTypes.Хэтчбек;
                            break;
                        case 1:
                            dataRow[4] = BodyTypes.Седан;
                            break;
                        case 2:
                            dataRow[4] = BodyTypes.Лифтбек;
                            break;
                        case 3:
                            dataRow[4] = BodyTypes.Универсал;
                            break;
                        case 4:
                            dataRow[4] = BodyTypes.Купе;
                            break;
                        case 5:
                            dataRow[4] = BodyTypes.Кроссовер;
                            break;
                        case 6:
                            dataRow[4] = BodyTypes.Внедорожник;
                            break;
                        case 7:
                            dataRow[4] = BodyTypes.Минивэн;
                            break;
                    }
                    switch (c.EngineType)
                    {
                        case 0:
                            dataRow[5] = EngineTypes.Бензин;
                            break;
                        case 1:
                            dataRow[5] = EngineTypes.Дизель;
                            break;
                        case 2:
                            dataRow[5] = EngineTypes.Газ;
                            break;
                        case 3:
                            dataRow[5] = EngineTypes.Водород;
                            break;
                        case 4:
                            dataRow[5] = EngineTypes.Электричество;
                            break;
                    }
                    dataRow[6] = c.Color;
                    dataRow[7] = c.Power;
                    dataRow[8] = c.ReleaseYear;
                    dataRow[9] = c.Vin;
                    dataRow[10] = c.Price.ToString("G29");
                    dataRow[11] = c.Notes;
                    switch (c.Status)
                    {
                        case 0:
                            dataRow[12] = Statuses.Новая;
                            break;
                        case 1:
                            dataRow[12] = Statuses.Резерв;
                            break;
                        case 2:
                            dataRow[12] = Statuses.Продана;
                            break;
                        case 3:
                            dataRow[12] = Statuses.Ремонт;
                            break;
                    }
                    dataRow[13] = c.IdCar;
                    dt.Rows.Add(dataRow);
                }
            }
            carsDgv.DataSource = dt;
            carsTS.Text = carsDgv.Rows.Count.ToString();
            filterTS.Text = "0";
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i][12].ToString() != filterCmb.Text)
                {
                    dt.Rows.Remove(dt.Rows[i]);
                }
            }
            filterTS.Text = carsDgv.Rows.Count.ToString();
        }

        private void clrFltrBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditCarsForm addCar = new AddEditCarsForm();
            Hide();
            if (addCar.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (carsDgv.SelectedRows.Count == 1)
            {
                AddEditCarsForm editCar = new AddEditCarsForm(Guid.Parse(carsDgv[13, carsDgv.SelectedRows[0].Index].Value.ToString()));
                Hide();
                if (editCar.ShowDialog() == DialogResult.OK)
                {
                    UpdateDgv();
                }
                Show();
            }
            else if (carsDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (carsDgv.SelectedRows.Count == 1)
            {
                using (DbDealershipManagmentContext db = new DbDealershipManagmentContext())
                {
                    if (db.Sales.FirstOrDefault(x => x.CarId == Guid.Parse(carsDgv[13,
                            carsDgv.SelectedRows[0].Index].Value.ToString())) == null
                            && db.Requests.FirstOrDefault(x => x.CarId == Guid.Parse(carsDgv[13,
                            carsDgv.SelectedRows[0].Index].Value.ToString())) == null)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить эту машину?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Cars.Remove(db.Cars.FirstOrDefault(x => x.IdCar == Guid.Parse(carsDgv[13,
                                carsDgv.SelectedRows[0].Index].Value.ToString())));
                            db.SaveChanges();
                            UpdateDgv();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эта машина уже была использована!", "Невозможно удалить", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else if (carsDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            if (carsDgv.SelectedRows.Count == 1)
            {
                using (var db = new DbDealershipManagmentContext())
                {
                    var car = db.Cars.FirstOrDefault(x => x.IdCar == Guid.Parse(carsDgv[13, carsDgv.SelectedRows[0].Index].Value.ToString()));
                    car.Status = statusCmb.SelectedIndex;
                    db.SaveChanges();
                    UpdateDgv();
                }
            }
            else if (carsDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void carsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusCmb.SelectedItem = carsDgv.Rows[carsDgv.SelectedRows[0].Index].Cells[12].Value;
        }

        private void carsDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            statusCmb.SelectedItem = carsDgv.Rows[carsDgv.SelectedRows[0].Index].Cells[12].Value;
        }
    }
}
