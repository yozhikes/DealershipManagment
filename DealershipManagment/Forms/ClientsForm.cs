using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealershipManagment.Forms
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            clientsDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            clientsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            clientsDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= clientsDgv.Rows.Count - 1; i++)
                {
                    for (int j = 1; j <= clientsDgv.ColumnCount - 2; j++)
                    {
                        if (clientsDgv.Rows[i].Cells[j].Value != null && clientsDgv.Rows[i].Cells[j].Value.ToString()
                            .ToUpper().Contains(searchTxt.Text.ToUpper()))
                        {
                            clientsDgv.Rows[i].Cells[j].Selected = true;
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditClientForm addClient = new AddEditClientForm();
            Hide();
            if (addClient.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (clientsDgv.SelectedRows.Count == 1)
            {
                AddEditClientForm editclient = new AddEditClientForm(Guid.Parse(clientsDgv[0, clientsDgv.SelectedRows[0].Index].Value.ToString()));
                Hide();
                if (editclient.ShowDialog() == DialogResult.OK)
                {
                    UpdateDgv();
                }
                Show();
            }
            else if (clientsDgv.SelectedRows.Count > 1)
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
            if (clientsDgv.SelectedRows.Count == 1)
            {
                using (var db = new DbDealershipManagmentContext())
                {
                    if (db.Sales.FirstOrDefault(x => x.ClientId == Guid.Parse(clientsDgv[0,
                            clientsDgv.SelectedRows[0].Index].Value.ToString())) == null)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить этот отчёт?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Clients.Remove(db.Clients.FirstOrDefault(x => x.IdClient == Guid.Parse(clientsDgv[0,
                            clientsDgv.SelectedRows[0].Index].Value.ToString())));
                            db.SaveChanges();
                            UpdateDgv();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Этот клиент уже был использован!", "Невозможно удалить", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (clientsDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateDgv()
        {
            using (var db = new DbDealershipManagmentContext())
            {
                clientsDgv.DataSource = db.Clients.ToList();
            }
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            clientsDgv.Columns[0].HeaderText = "idClient";
            clientsDgv.Columns[1].HeaderText = "ФИО";
            clientsDgv.Columns[2].HeaderText = "Паспорт";
            clientsDgv.Columns[3].HeaderText = "Номер телефона";
            clientsDgv.Columns[0].Visible = false;
            clientsDgv.Columns[4].Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
