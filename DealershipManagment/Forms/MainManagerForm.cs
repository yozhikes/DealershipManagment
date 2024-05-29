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
    public partial class MainManagerForm : Form
    {
        public MainManagerForm()
        {
            InitializeComponent();
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            ClientsForm clients = new ClientsForm();
            Hide();
            if (clients.ShowDialog() == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            SalesForm sales = new SalesForm();
            Hide();
            if (sales.ShowDialog() == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
