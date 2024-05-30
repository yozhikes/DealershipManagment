using DealershipManagment.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealershipManagment
{
    public partial class SalesForm : Form
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        public SalesForm()
        {
            InitializeComponent();
            salesDgv.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14);
            salesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt.Columns.Add("Машина");
            dt.Columns.Add("Клиент");
            dt.Columns.Add("Менеджер");
            dt.Columns.Add("Итого");
            dt.Columns.Add("Примечания");
            dt.Columns.Add("Дата продажи");
            dt.Columns.Add("idSale");
            using (DbDealershipManagmentContext db = new DbDealershipManagmentContext())
            {
                filterCmb.DataSource = db.Sales.Include(x => x.Worker).Select(x => x.Worker.Fio).Distinct().ToList();
            }
            filterCmb.SelectedIndex = 0;
        }

        private void UpdateDgv()
        {
            dt.Clear();
            using (var db = new DbDealershipManagmentContext())
            {
                var sales = db.Sales
                .Include(x => x.Worker)
                .Include(x => x.Car)
                .Include(x => x.Client)
                .Include(x => x.Car.Mark)
                .ToList();
                foreach (var s in sales)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow[0] = $"{s.Car.Mark.NameMark} {s.Car.Model}";
                    dataRow[1] = s.Client.Fio;
                    dataRow[2] = s.Worker.Fio;
                    dataRow[3] = s.Total.ToString("G29");
                    dataRow[4] = s.Notes;
                    dataRow[5] = s.DateSale;
                    dataRow[6] = s.IdSale;
                    dt.Rows.Add(dataRow);
                }
            }
            salesDgv.DataSource = dt;
            salesTS.Text = salesDgv.Rows.Count.ToString();
            filterTS.Text = "0";
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            filterCmb.SelectedIndex = 0;
            salesDgv.Columns[6].Visible = false;
            salesDgv.Sort(salesDgv.Columns[6], ListSortDirection.Ascending);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditSalesForm addSale = new AddEditSalesForm();
            Hide();
            if (addSale.ShowDialog() == DialogResult.OK)
            {
                UpdateDgv();
                using (var db = new DbDealershipManagmentContext())
                {
                    filterCmb.DataSource = db.Sales.Include(x => x.Worker).Select(x => x.Worker.Fio).Distinct().ToList();
                }
            }
            Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (salesDgv.SelectedRows.Count == 1)
            {
                AddEditSalesForm editSale = new AddEditSalesForm(Guid.Parse(salesDgv[6, salesDgv.SelectedRows[0].Index].Value.ToString()));
                Hide();
                if (editSale.ShowDialog() == DialogResult.OK)
                {
                    UpdateDgv();
                    using (var db = new DbDealershipManagmentContext())
                    {
                        filterCmb.DataSource = db.Sales.Include(x => x.Worker).Select(x => x.Worker.Fio).Distinct().ToList();
                    }
                }
                Show();
            }
            else if (salesDgv.SelectedRows.Count > 1)
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
            if (salesDgv.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Вы действительно хотите удалить эту продажу?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new DbDealershipManagmentContext())
                    {
                        db.Sales.Remove(db.Sales.FirstOrDefault(x => x.IdSale == Guid.Parse(salesDgv[6,
                        salesDgv.SelectedRows[0].Index].Value.ToString())));
                        db.SaveChanges();
                        filterCmb.DataSource = db.Sales.Include(x => x.Worker).Select(x => x.Worker.Fio).Distinct().ToList();
                    }
                    UpdateDgv();
                }
            }
            else if (salesDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void clrFltrBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            UpdateDgv();
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i][2].ToString() != filterCmb.Text)
                {
                    dt.Rows.Remove(dt.Rows[i]);
                }
            }
            filterTS.Text = salesDgv.Rows.Count.ToString();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            salesDgv.ClearSelection();
            var quantity = 0;
            if (searchTxt.Text != string.Empty)
            {
                for (int i = 0; i <= salesDgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= salesDgv.ColumnCount - 2; j++)
                    {
                        if (salesDgv.Rows[i].Cells[j].Value != null && salesDgv.Rows[i].Cells[j].Value.ToString()
                            .ToUpper().Contains(searchTxt.Text.ToUpper()))
                        {
                            salesDgv.Rows[i].Cells[j].Selected = true;
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

        private void documentBtn_Click(object sender, EventArgs e)
        {
            if (salesDgv.SelectedRows.Count == 1)
            {
                using (var db = new DbDealershipManagmentContext())
                {
                    var sale = db.Sales
                        .Include(x=>x.Car)
                        .Include(x=>x.Worker)
                        .Include(x=>x.Client)
                        .Include(x=>x.Car.Mark)
                        .FirstOrDefault(x => x.IdSale == Guid.Parse(salesDgv[6,salesDgv.SelectedRows[0].Index].Value.ToString()));
                // Создаем новый Word-документ
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();

                // Получаем шаблон Word-документа
                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "templateDogovor.docx");
                wordDoc = wordApp.Documents.Open(templatePath);

                // Заполняем данные из DataGridView в шаблон

                // Замените плейсхолдеры в шаблоне на соответствующие данные
                wordDoc.Bookmarks["dateSale"].Range.Text = sale.DateSale.ToShortDateString();
                wordDoc.Bookmarks["worker"].Range.Text = sale.Worker.Fio;
                wordDoc.Bookmarks["client"].Range.Text = sale.Client.Fio;
                wordDoc.Bookmarks["VIN"].Range.Text = sale.Car.Vin;
                wordDoc.Bookmarks["markModel"].Range.Text = $"{sale.Car.Mark.NameMark} {sale.Car.Model}";
                wordDoc.Bookmarks["year"].Range.Text = sale.Car.ReleaseYear.ToString();
                wordDoc.Bookmarks["color"].Range.Text = sale.Car.Color;
                wordDoc.Bookmarks["power"].Range.Text = sale.Car.Power.ToString();
                wordDoc.Bookmarks["transmission"].Range.Text = Enum.GetName((Transmissions)sale.Car.Transmission);
                wordDoc.Bookmarks["drive"].Range.Text = Enum.GetName((Drives)sale.Car.Transmission);
                wordDoc.Bookmarks["bodyType"].Range.Text = Enum.GetName((BodyTypes)sale.Car.Transmission);
                wordDoc.Bookmarks["engineType"].Range.Text = Enum.GetName((EngineTypes)sale.Car.Transmission);
                wordDoc.Bookmarks["total"].Range.Text = sale.Total.ToString("G29");
                wordDoc.Bookmarks["clientFio"].Range.Text = sale.Client.Fio;
                wordDoc.Bookmarks["seriyaPass"].Range.Text = sale.Client.Pass.Substring(0,4);
                wordDoc.Bookmarks["numberPass"].Range.Text = sale.Client.Pass.Substring(4, 6);
                wordDoc.Bookmarks["clientFio2"].Range.Text = sale.Client.Fio;
                wordDoc.Bookmarks["worker2"].Range.Text = sale.Worker.Fio;
                string savePath = "Договор.docx";
                wordDoc.SaveAs2(savePath);
                wordApp.Visible = true;

                }
            }
            else if (salesDgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберете только одну строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Не была выбрана строка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
