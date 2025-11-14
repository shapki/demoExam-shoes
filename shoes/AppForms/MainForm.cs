using shoes.CustomControls;
using shoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class MainForm : Form
    {
        private string _role;
        public MainForm(string fullName, string role)
        {
            InitializeComponent();
            userFullNameLabel.Text = fullName;
            _role = role;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            ShowProducts();
        }

        private void ShowProducts()
        {
            List<Product> products = Program.context.Product.OrderBy(p => p.ProductName).ToList();

            foreach (Product product in products)
            {
                contentFlowLayoutPanel.Controls.Add(new ProductUserControl(product));
            }
        }

        private void logOutButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
            OpenAuthForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenAuthForm();
        }

        private void OpenAuthForm()
        {
            if (Program.authForm != null && !Program.authForm.IsDisposed)
            {
                Program.authForm.Show();
                Program.authForm.BringToFront();
            }
            else
            {
                Program.authForm = new AuthForm();
                Program.authForm.Show();
            }
        }
    }
}
