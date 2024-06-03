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

namespace DealershipManagment.Forms
{
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void marksBtn_Click(object sender, EventArgs e)
        {
            MarksForm marksForm = new MarksForm();
            Hide();
            if (marksForm.ShowDialog() == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void rezervBtn_Click(object sender, EventArgs e)
        {
            string backupFileName = $"Backup_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.bak";
            string backupFilePath = Path.Combine(Application.StartupPath,"Backups",backupFileName);
            using (var db = new DbDealershipManagmentContext())
            {
                // Создаем копию базы данных с помощью DbContext.Database.ExecuteSqlRaw()
                db.Database.ExecuteSqlRaw($"BACKUP DATABASE [Db_DealershipManagment] TO DISK = '{backupFilePath}'");
            }
            MessageBox.Show("Резервное копирование базы данных выполнено успешно.");
        }
    }
}
