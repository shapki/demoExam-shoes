using shoes.AppForms;
using shoes.Models;
using System;
using System.Windows.Forms;

namespace shoes
{
    static class Program
    {
        public static ShoesModel context = new ShoesModel();
        public static AuthForm authForm;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!context.Database.Exists())
            {
                MessageBox.Show("Не удается установить соединение с базой данных");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            authForm = new AuthForm();
            Application.Run(authForm);
        }
    }
}
