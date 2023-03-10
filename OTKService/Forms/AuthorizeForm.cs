using MySqlConnector;
using OTKService.Entities;

namespace OTKService.Forms
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private (string, string) CheckFields()
        {
            TextBox loginBox = (TextBox)Controls.Find("LoginBox", true)[0];
            TextBox passwordBox = (TextBox)Controls.Find("PasswordBox", true)[0];
            if (loginBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите недостающие данные", "Ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (loginBox.Text, passwordBox.Text);
        }

        private void OnAuthorize(object sender, EventArgs e)
        {
            var (login, password) = CheckFields();
            if (login == "" || password == "")
            {
                return;
            }

            string username = "";
            try
            {
                username = Worker.GetNameByLoginAndPassword(login, password);
                if (username == "")
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateOrderForm orderForm = new(this, username);
            orderForm.Show();
            Hide();
        }

        private void PasswordVisibleCheckChange(object sender, EventArgs e)
        {
            TextBox passwordBox = (TextBox)Controls.Find("PasswordBox", true)[0];
            if (passwordBox != null)
            {
                passwordBox.UseSystemPasswordChar = !passwordBox.UseSystemPasswordChar;
            }
        }
    }
}