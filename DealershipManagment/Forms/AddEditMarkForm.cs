using DealershipManagment.Tables;
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
    public partial class AddEditMarkForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
        Mark mark = new Mark();
        public AddEditMarkForm()
        {
            InitializeComponent();
            Text = "Добавить";
            addEditBtn.Text = "Добавить";
        }

        public AddEditMarkForm(Guid i)
        {
            InitializeComponent();
            Text = "Изменить";
            addEditBtn.Text = "Изменить";
            mark = db.Marks.FirstOrDefault(x => x.IdMark == i);
        }

        private void AddEditMarkForm_Load(object sender, EventArgs e)
        {
            if (Text == "Изменить")
            {
                markTxt.Text = mark.NameMark;
            }
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            if (markTxt.Text != string.Empty)
            {
                    mark.NameMark = markTxt.Text;
                    if (addEditBtn.Text == "Добавить")
                    {
                        mark.IdMark = Guid.NewGuid();
                        db.Marks.Add(mark);
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
    }
}
