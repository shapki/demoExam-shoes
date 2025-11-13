using shoes.CustomControls;
using shoes.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        }
    }
}
