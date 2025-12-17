using shoes.AppForms;
using shoes.Models;
using shoes.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace shoes.CustomControls
{
    public partial class OrderUserControl : UserControl
    {
        private Order _order;
        private string _role;
        UserRole adminRole = UserRole.Administrator;

        public event EventHandler<Order> OrderClicked;

        public OrderUserControl(Order order, string role)
        {
            InitializeComponent();
            _order = order;
            _role = role;
            SetLabelTextValues();

            foreach (Control control in this.Controls)
            {
                control.Click += OrderUserControl_Click;
            }
        }

        private void CheckUserRole()
        {
            if (_role == adminRole.GetDescription())
            {
                this.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            else
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void SetLabelTextValues()
        {
            if (_order != null)
            {
                scuLabel.Text += _order.Code.ToString("000000");
                statusLabel.Text += _order.Status;
                officeLabel.Text += GetOfficeAddress(_order.OfficeId);
                orderDateLabel.Text += _order.OrderDate.ToString("dd.MM.yyyy");
                deliveryDateLabel.Text += _order.DeliveryDate.ToString("dd.MM.yyyy");
            }
        }

        private string GetOfficeAddress(int officeId)
        {
            try
            {
                if (_order.Office != null)
                {
                    return $"{_order.Office.Address}";
                }

                using (var context = Program.context)
                {
                    var office = context.Office.FirstOrDefault(o => o.IdOffice == officeId);
                    if (office != null)
                    {
                        return $"{office.Address}";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка получения адреса офиса: {ex.Message}");
            }

            return "Адрес пункта выдачи не указан";
        }

        private void OrderUserControl_Click(object sender, EventArgs e)
        {
            if (_role == adminRole.GetDescription())
            {
                var editForm = new CreateUpdateOrderForm(_order);
                editForm.OrderSaved += (s, updatedOrder) =>
                {
                    OrderClicked?.Invoke(this, updatedOrder);
                };
                editForm.ShowDialog();
            }
        }

        private void OrderUserControl_Load(object sender, EventArgs e)
        {
            CheckUserRole();
        }
    }
}