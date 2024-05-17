namespace DealershipManagment
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
        }

        private void entryBtn_Click(object sender, EventArgs e)
        {
            if (true)
            {
                int goida = 0;
                switch (goida)
                {
                    case 0:
                        AdminForm admin = new AdminForm();
                        Hide();
                        admin.ShowDialog();
                        Show();
                        break;
                    case 1:
                        CarsForm cars = new CarsForm();
                        Hide();
                        cars.ShowDialog();
                        Show();
                        break;
                    case 2:
                        FinancesForm finances = new FinancesForm();
                        Hide();
                        finances.ShowDialog();
                        Show();
                        break;
                    case 3:
                        SalesForm sales = new SalesForm();
                        Hide();
                        sales.ShowDialog();
                        Show();
                        break;
                    case 4:
                        ServiceForm service = new ServiceForm();
                        Hide();
                        service.ShowDialog();
                        Show();
                        break;
                    case 5:
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

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = !passCheck.Checked;
        }
    }
}
