﻿using DealershipManagment.Enums;
using DealershipManagment.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealershipManagment
{
    public partial class AddEditWorkersForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
        Guid workerId = Guid.Empty;
        public AddEditWorkersForm()
        {
            InitializeComponent();
            Text = "Добавить";
            addEditBtn.Text = "Добавить";
        }

        public AddEditWorkersForm(Guid i)
        {
            InitializeComponent();
            Text = "Изменить";
            addEditBtn.Text = "Изменить";
            workerId = i;
        }

        private void AddEditWorkersForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Roles)))
            {
                roleCmb.Items.Add(item.ToString());
            }
            roleCmb.SelectedIndex = 0;
            if (Text == "Изменить")
            {
                var worker = db.Workers.FirstOrDefault(x => x.IdWorker == workerId);
                fioTxt.Text = worker.Fio;
                passTxt.Text = worker.Pass;
                telnumTxt.Text = worker.TelNum;
                loginTxt.Text = worker.Login;
                roleCmb.SelectedIndex = worker.RoleId;
            }
        }

        public static string HashWithSHA256(string input)
        {
            // Создаем экземпляр SHA256 хэш-алгоритма
            using (SHA256 sha256 = SHA256.Create())
            {
                // Преобразуем входную строку в байты
                byte[] bytes = Encoding.UTF8.GetBytes(input);

                // Вычисляем хэш
                byte[] hash = sha256.ComputeHash(bytes);

                // Преобразуем хэш в строку
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            var worker = new Worker();
            if (addEditBtn.Text == "Изменить")
            {
                worker = db.Workers.FirstOrDefault(x => x.IdWorker == workerId);
            }
            if (fioTxt.Text != string.Empty && passTxt.Text != string.Empty && telnumTxt.Text.Length == 17
                && passwordTxt.Text != string.Empty && passTxt.Text.Length == 10)
            {
                worker.Fio = fioTxt.Text;
                worker.Pass = passTxt.Text;
                worker.TelNum = telnumTxt.Text;
                worker.Login = loginTxt.Text;
                worker.Password = HashWithSHA256(passwordTxt.Text);
                worker.RoleId = roleCmb.SelectedIndex;
                if (addEditBtn.Text == "Добавить")
                {
                    worker.IdWorker = Guid.NewGuid();
                    worker.Status = 0;
                    db.Workers.Add(worker);
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void passTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
