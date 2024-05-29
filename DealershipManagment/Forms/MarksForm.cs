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
    public partial class MarksForm : Form
    {
        public MarksForm()
        {
            InitializeComponent();
            marksDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            marksDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditMarkForm addmark = new AddEditMarkForm();
            Hide();
            if (addmark.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
            }
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (marksDgv.SelectedRows.Count == 1)
            {
                AddEditMarkForm editmark = new AddEditMarkForm(Guid.Parse(marksDgv[0, marksDgv.SelectedRows[0].Index].Value.ToString()));
                Hide();
                if (editmark.ShowDialog() == DialogResult.OK)
                {
                    UpdateDgv();
                }
                Show();
            }
            else if (marksDgv.SelectedRows.Count > 1)
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
            if (marksDgv.SelectedRows.Count == 1)
            {
                using (var db = new DbDealershipManagmentContext())
                {
                    if (db.Cars.FirstOrDefault(x=>x.MarkId== Guid.Parse(marksDgv[0,
                            marksDgv.SelectedRows[0].Index].Value.ToString()))==null)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить этот отчёт?", "Удаление",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            db.Marks.Remove(db.Marks.FirstOrDefault(x => x.IdMark == Guid.Parse(marksDgv[0,
                            marksDgv.SelectedRows[0].Index].Value.ToString())));
                            db.SaveChanges();
                            UpdateDgv();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эта марка уже была использована!", "Невозможно удалить", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (marksDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            marksDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= marksDgv.Rows.Count - 1; i++)
                {
                    for (int j = 1; j <= marksDgv.ColumnCount - 2; j++)
                    {
                        if (marksDgv.Rows[i].Cells[j].Value != null && marksDgv.Rows[i].Cells[j].Value.ToString()
                            .ToUpper().Contains(searchTxt.Text.ToUpper()))
                        {
                            marksDgv.Rows[i].Cells[j].Selected = true;
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

        private void UpdateDgv()
        {
            using (var db = new DbDealershipManagmentContext())
            {
                marksDgv.DataSource = db.Marks.ToList();
            }
        }

        private void MarksForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            marksDgv.Columns[0].HeaderText = "idMark";
            marksDgv.Columns[1].HeaderText = "Название марки";
            marksDgv.Columns[0].Visible = false;
            marksDgv.Columns[2].Visible = false;
        }
    }
}
