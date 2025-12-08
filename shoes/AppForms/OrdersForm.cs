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

        public OrdersForm(string userRole = "")
        {
            InitializeComponent();
            _currentUserRole = userRole;
            CheckUserRole();
        }

        private void CheckUserRole()
        {
            if (_currentUserRole == adminRole.GetDescription())
            {
                addOrderButton.Visible = true;
                formSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            }
            else
            {
                addOrderButton.Visible = false;
                formSplitContainer.SplitterDistance = 70;
            }
        }

        /// <summary>
        /// PKGH: Загрузка всех заказов из бд
        /// </summary>
        private void LoadOrders()
        {
            try
            {
                contentFlowLayoutPanel.Controls.Clear();

                using (var context = new ShoesModel())
                {
                    var orders = context.Order
                        .Include("Office")
                        .Include("User")
                        .OrderByDescending(o => o.OrderDate)
                        .ToList();

                    foreach (var order in orders)
                    {
                        var orderControl = new OrderUserControl(order, _currentUserRole);
                        orderControl.OrderClicked += OrderControl_OrderClicked;
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

        private void OrderControl_OrderClicked(object sender, Order order)
        {
            LoadOrders();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            using (var createForm = new CreateUpdateOrderForm())
            {
                createForm.OrderSaved += (s, order) =>
                {
                    LoadOrders();
                };
                createForm.ShowDialog();
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}