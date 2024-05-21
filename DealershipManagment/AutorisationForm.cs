namespace DealershipManagment
{
    public partial class AutorisationForm : Form
    {
        DbDealershipManagmentContext db = new DbDealershipManagmentContext();
        public AutorisationForm()
        {
            InitializeComponent();
            passTxt.UseSystemPasswordChar = true;
        }

        private void entryBtn_Click(object sender, EventArgs e)
        {
            if(loginTxt.Text==string.Empty && passTxt.Text==string.Empty)
            {
                MessageBox.Show("Некоторые или все поля пустые!", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var worker = db.Workers.FirstOrDefault(x => x.Login == loginTxt.Text && x.Password == passTxt.Text);
                if (worker != null)
                {
                    var role = worker.RoleId;
                    switch (role)
                    {
                        case 2:
                            CarsForm cars = new CarsForm();
                            Hide();
                            cars.ShowDialog();
                            Show();
                            break;
                        case 3:
                            FinancesForm finances = new FinancesForm();
                            Hide();
                            finances.ShowDialog();
                            Show();
                            break;
                        case 4:
                            SalesForm sales = new SalesForm();
                            Hide();
                            sales.ShowDialog();
                            Show();
                            break;
                        case 5:
                            ServiceForm service = new ServiceForm();
                            Hide();
                            service.ShowDialog();
                            Show();
                            break;
                        case 6:
                            StaffForm staff = new StaffForm();
                            Hide();
                            staff.ShowDialog();
                            Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин и/или пароль", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = !passCheck.Checked;
        }
    }
}
