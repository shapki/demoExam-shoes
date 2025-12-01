using System.Windows.Forms;
using System.Linq;
using shoes.Services;
using shoes.Models;

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

            if (ValidationHelper.ValidationLogin(login) &&
                ValidationHelper.ValidationPassword(password))
            {
                using (var context = new ShoesModel())
                {
                    var user = context.User.FirstOrDefault(em =>
                        em.Login == login && em.Password == password);

                    if (user != null)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm(user.FullName, user.Role);
                        mainForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя в базе данных нет!",
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Некорректный формат логина или пароля!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guestLogInButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm("Гостевой аккаунт", "Гость");
            mainForm.ShowDialog();
            this.Show();
        }
    }
}