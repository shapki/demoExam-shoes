using shoes.CustomControls;
using shoes.Models;
using shoes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class MainForm : Form
    {
        private string _role;
        private int sortMode = 0;
        private string sortButtonText = "Сортировка по кол-ву ";
        public MainForm(string fullName, string role)
        {
            InitializeComponent();
            userFullNameLabel.Text = fullName;
            _role = role;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_DemoShoesDataSet.Supplyer". При необходимости она может быть перемещена или удалена.
            this.supplyerTableAdapter.Fill(this.shapkin_DemoShoesDataSet.Supplyer);
            ShowProducts();
            CheckUserRole();
        }

        private void CheckUserRole()
        {
            UserRole adminRole = UserRole.Administrator;
            UserRole managerRole = UserRole.Manager;
            if (_role == adminRole.GetDescription() || _role == managerRole.GetDescription())
            {
                filterComboBox.Visible = true;
                sortButton.Visible = true;
                searchTextBox.Visible = true;
                searchButton.Visible = true;
                formSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            } else
            {
                formSplitContainer.SplitterDistance = 70;
            }
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

        private void sortButton_Click(object sender, EventArgs e)
        {
            ChangeSortMode();
        }

        private void ChangeSortMode()
        {
            sortMode++;
            switch (sortMode)
            {
                case 1:
                    sortButton.Text = sortButtonText + "▼";
                    break;
                case 2:
                    sortButton.Text = sortButtonText + "▲";
                    break;
                default:
                    sortMode = 0;
                    sortButton.Text = sortButtonText + "■";
                    break;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
