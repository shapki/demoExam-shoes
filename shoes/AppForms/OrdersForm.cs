using shoes.CustomControls;
using shoes.Models;
using shoes.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class OrdersForm : Form
    {
        private string _currentUserRole;

        UserRole adminRole = UserRole.Administrator;
        UserRole managerRole = UserRole.Manager;

        public OrdersForm(string userRole = "")
        {
            InitializeComponent();
            _currentUserRole = userRole;
            CheckUserRole();
        }

        private void CheckUserRole()
        {
            if (_currentUserRole == adminRole.GetDescription() || _currentUserRole == managerRole.GetDescription())
            {
                addOrderButton.Visible = true;
            }
            else
            {
                addOrderButton.Visible = false;
            }
        }

        private void LoadOrders()
        {
            try
            {
                contentFlowLayoutPanel.Controls.Clear();

                using (var context = Program.context)
                {
                    var orders = context.Order
                        .Include("Office")
                        .Include("User")
                        .OrderByDescending(o => o.OrderDate)
                        .ToList();

                    foreach (var order in orders)
                    {
                        var orderControl = new OrderUserControl(order, _currentUserRole);
                        contentFlowLayoutPanel.Controls.Add(orderControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заказов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderControl_OrderClicked(object sender, Product product)
        {
            MessageBox.Show($"Выбран заказ с продуктом: {product.ProductName}", "Информация о заказе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {

        }

        public void RefreshOrders()
        {
            LoadOrders();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}