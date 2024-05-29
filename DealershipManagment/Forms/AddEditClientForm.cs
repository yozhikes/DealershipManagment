using DealershipManagment.Tables;
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
    public partial class AddEditClientForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
        Client client = new Client();
        public AddEditClientForm()
        {
            InitializeComponent();
            Text = "Добавить";
            addEditBtn.Text = "Добавить";
        }

        public AddEditClientForm(Guid i)
        {
            InitializeComponent();
            Text = "Изменить";
            addEditBtn.Text = "Изменить";
            client = db.Clients.FirstOrDefault(x => x.IdClient == i);
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            if (fioTxt.Text != string.Empty && passTxt.Text != string.Empty
                && passTxt.Text.Length == 10 && telnumTxt.Text.Length == 17)
            {
                    client.Fio = fioTxt.Text;
                    client.Pass = passTxt.Text;
                    client.TelNum = telnumTxt.Text;
                    if (addEditBtn.Text == "Добавить")
                    {
                        client.IdClient = Guid.NewGuid();
                        db.Clients.Add(client);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Данные внесены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
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

        private void AddEditClientForm_Load(object sender, EventArgs e)
        {
            if (Text == "Изменить")
            {
                fioTxt.Text = client.Fio;
                passTxt.Text = client.Pass;
                telnumTxt.Text = client.TelNum;
            }
        }

        private void passTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
