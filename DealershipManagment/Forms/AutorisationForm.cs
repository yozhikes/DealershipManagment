using DealershipManagment.Forms;
using System.Security.Cryptography;
using System.Text;

namespace DealershipManagment
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
            passTxt.UseSystemPasswordChar = true;
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

        private void entryBtn_Click(object sender, EventArgs e)
        {
            if (loginTxt.Text == string.Empty && passTxt.Text == string.Empty)
            {
                MessageBox.Show("Некоторые или все поля пустые!", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using(DbDealershipManagmentContext db = new DbDealershipManagmentContext())
                {
                    var worker = db.Workers.FirstOrDefault(x => x.Login == loginTxt.Text && x.Password == HashWithSHA256(passTxt.Text));
                    if (worker != null)
                    {
                        if (worker.Status != 2)
                        {
                            var role = worker.RoleId;
                            switch (role)
                            {
                                case 0:
                                    CarsForm cars = new CarsForm();
                                    Hide();
                                    if (cars.ShowDialog() == DialogResult.Cancel)
                                    {
                                        loginTxt.Text = string.Empty;
                                        passTxt.Text = string.Empty;
                                        Show();
                                    }
                                    break;
                                case 1:
                                    FinancesForm finances = new FinancesForm();
                                    Hide();
                                    if (finances.ShowDialog() == DialogResult.Cancel)
                                    {
                                        loginTxt.Text = string.Empty;
                                        passTxt.Text = string.Empty;
                                        Show();
                                    }
                                    break;
                                case 2:
                                    MainManagerForm manager = new MainManagerForm();
                                    Hide();
                                    if (manager.ShowDialog() == DialogResult.Cancel)
                                    {
                                        loginTxt.Text = string.Empty;
                                        passTxt.Text = string.Empty;
                                        Show();
                                    }
                                    break;
                                case 3:
                                    ServiceForm service = new ServiceForm();
                                    Hide();
                                    if (service.ShowDialog() == DialogResult.Cancel)
                                    {
                                        loginTxt.Text = string.Empty;
                                        passTxt.Text = string.Empty;
                                        Show();
                                    }
                                    break;
                                case 4:
                                    StaffForm staff = new StaffForm();
                                    Hide();
                                    if (staff.ShowDialog() == DialogResult.Cancel)
                                    {
                                        loginTxt.Text = string.Empty;
                                        passTxt.Text = string.Empty;
                                        Show();
                                    }
                                    break;
                                case 5:
                                    MainAdminForm adminForm = new MainAdminForm();
                                    Hide();
                                    if (adminForm.ShowDialog() == DialogResult.Cancel)
                                    {
                                        loginTxt.Text = string.Empty;
                                        passTxt.Text = string.Empty;
                                        Show();
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данный работник уволен!", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин и/или пароль", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = !passCheck.Checked;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
