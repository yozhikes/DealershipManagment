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
        public CarsForm()
        {
            InitializeComponent();
            carsDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            carsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                        if (carsDgv.Rows[i].Cells[j].Value != null && carsDgv.Rows[i].Cells[j].Value.ToString() == searchTxt.Text)
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

        private void filterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
