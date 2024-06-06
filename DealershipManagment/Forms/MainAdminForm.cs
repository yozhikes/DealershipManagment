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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Файлы резервной копии(*.bak)|*.bak";
                saveFileDialog.FileName = $"Backup_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.bak";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = saveFileDialog.FileName;

                    using (var db = new DbDealershipManagmentContext())
                    {
                        // Создаем копию базы данных
                        db.Database.ExecuteSqlRaw($"BACKUP DATABASE [Db_DealershipManagment] TO DISK = '{selectedFilePath}'");
                    }

                    MessageBox.Show("Резервное копирование базы данных выполнено успешно.");
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
