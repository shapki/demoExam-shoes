using System.Windows.Forms;
using System.Linq;
using System;

namespace shoes.AppForms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, System.EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = Program.context)
                {
                    var user = context.User
                        .FirstOrDefault(u => u.Login == login && u.Password == password);

                    if (user != null)
                    {
                        string fullName = user.FullName;
                        string role = user.Role;
                        this.Hide();
                        MainForm mainForm = new MainForm(fullName, role);
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guestLogInButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm("Гостевой Аккаунт", "Гость");
            mainForm.Show();
        }
    }
}