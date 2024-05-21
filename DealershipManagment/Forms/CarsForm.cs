﻿using DealershipManagment.Enums;
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
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
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
            dt.Columns.Add("Год выпуска");
            dt.Columns.Add("VIN");
            dt.Columns.Add("Цена");
            dt.Columns.Add("Примечания");
            dt.Columns.Add("Статус");
            dt.Columns.Add("idCar");
            filterCmb.DataSource = db.Marks.Select(x => x.NameMark).ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            carsDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= carsDgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= carsDgv.ColumnCount - 1; j++)
                    {
                        if (carsDgv.Rows[i].Cells[j].Value != null && carsDgv.Rows[i].Cells[j].Value.ToString().Contains(searchTxt.Text))
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
            carsDgv.Columns[11].Visible = false;
        }

        private void UpdateDgv()
        {
            dt.Clear();
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
                dataRow[6] = c.ReleaseYear;
                dataRow[7] = c.Vin;
                dataRow[8] = c.Price;
                dataRow[9] = c.Notes;
                switch (c.Status)
                {
                    case 0:
                        dataRow[10] = Statuses.Новая;
                        break;
                    case 1:
                        dataRow[10] = Statuses.Резерв;
                        break;
                    case 2:
                        dataRow[10] = Statuses.Продана;
                        break;
                    case 3:
                        dataRow[10] = Statuses.Ремонт;
                        break;
                }
                dataRow[11] = c.IdCar;
                dt.Rows.Add(dataRow);
            }
            carsDgv.DataSource = dt;
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i][0].ToString() != filterCmb.Text)
                {
                    dt.Rows.Remove(dt.Rows[i]);
                }
            }
        }

        private void clrFltrBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditCarsForm addCar = new AddEditCarsForm();
            Hide();
            addCar.ShowDialog();
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            AddEditCarsForm editCar = new AddEditCarsForm(Guid.Parse(carsDgv[11,carsDgv.SelectedRows[0].Index].Value.ToString()));
            Hide();
            editCar.ShowDialog();
            Show();
        }
    }
}
