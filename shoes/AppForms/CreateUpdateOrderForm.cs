using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using shoes.Models;
using shoes.Services;

namespace shoes.AppForms
{
    public partial class CreateUpdateOrderForm : Form
    {
        private Order _order;
        private bool _isEditMode;
        private OrderService _orderService;

        public event EventHandler<Order> OrderSaved;

        public CreateUpdateOrderForm()
        {
            InitializeComponent();
            _isEditMode = false;
            _orderService = new OrderService(Program.context);
            InitializeForm();
        }

        public CreateUpdateOrderForm(Order order)
        {
            InitializeComponent();
            _order = order;
            _isEditMode = true;
            _orderService = new OrderService(Program.context);
            InitializeForm();
        }

        private void InitializeForm()
        {
            saveButton.Visible = true;

            if (_isEditMode)
            {
                this.Text = "ООО \"Обувь\" | Редактирование заказа";
                headerSubtitleLabel.Text = "Редактирование заказа";
                deleteOrderButton.Visible = true;
                LoadComboBoxData();
                BindOrderToControls();
            }
            else
            {
                this.Text = "ООО \"Обувь\" | Создание заказа";
                headerSubtitleLabel.Text = "Создание заказа";
                deleteOrderButton.Visible = false;
                saveButton.Text = "Добавить заказ";
                saveButton.Size = new System.Drawing.Size(221, 22);
                _order = new Order
                {
                    OrderDate = DateTime.Now,
                    Status = "Новый"
                };
                LoadComboBoxData();
                SetDefaultValues();
            }
        }

        private void SetDefaultValues()
        {
            orderDateDateTimePicker.Value = DateTime.Now;
            deliveryDateDateTimePicker.Value = DateTime.Now.AddDays(3);
            statusComboBox.SelectedItem = "Новый";
            codeTextBox.Text = GenerateOrderCode().ToString();
            _order.DeliveryDate = DateTime.Now.AddDays(3);
        }

        private void LoadComboBoxData()
        {
            try
            {
                var statuses = new List<string>
                {
                    "Новый",
                    "Завершен"
                };

                statusComboBox.DataSource = statuses;
                statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                using (var context = new ShoesModel())
                {
                    var offices = context.Office
                        .OrderBy(o => o.Address)
                        .ToList();

                    officeIdComboBox.DataSource = offices;
                    officeIdComboBox.DisplayMember = "Address";
                    officeIdComboBox.ValueMember = "IdOffice";
                    officeIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                    var users = context.User
                        .OrderBy(u => u.FullName)
                        .ToList();

                    userIdComboBox.DataSource = users;
                    userIdComboBox.DisplayMember = "FullName";
                    userIdComboBox.ValueMember = "IdUser";
                    userIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindOrderToControls()
        {
            try
            {
                if (_order != null)
                {
                    if (_order.Code != 0)
                    {
                        codeTextBox.Text = _order.Code.ToString();
                    }

                    if (!string.IsNullOrEmpty(_order.Status))
                    {
                        statusComboBox.SelectedItem = _order.Status;
                    }
                    else
                    {
                        statusComboBox.SelectedItem = "Новый";
                    }

                    if (_order.OfficeId > 0)
                    {
                        officeIdComboBox.SelectedValue = _order.OfficeId;
                    }

                    if (_order.OrderDate != null && _order.OrderDate != DateTime.MinValue)
                    {
                        orderDateDateTimePicker.Value = _order.OrderDate;
                    }
                    else
                    {
                        orderDateDateTimePicker.Value = DateTime.Now;
                    }

                    // Проверяем DeliveryDate на DateTime.MinValue
                    if (_order.DeliveryDate != DateTime.MinValue)
                    {
                        deliveryDateDateTimePicker.Value = _order.DeliveryDate;
                    }
                    else
                    {
                        deliveryDateDateTimePicker.Value = DateTime.Now.AddDays(3);
                        _order.DeliveryDate = deliveryDateDateTimePicker.Value;
                    }

                    if (_order.UserId > 0)
                    {
                        userIdComboBox.SelectedValue = _order.UserId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GenerateOrderCode()
        {
            var random = new Random();
            return random.Next(1000, 9999);
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_DemoShoesDataSet);
        }

        private void CreateUpdateOrderForm_Load(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                LoadComboBoxData();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateAndUpdateOrder())
            {
                try
                {
                    bool success = false;

                    if (_isEditMode)
                    {
                        success = _orderService.UpdateOrder(_order);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(codeTextBox.Text) || !int.TryParse(codeTextBox.Text, out _))
                        {
                            _order.Code = GenerateOrderCode();
                            codeTextBox.Text = _order.Code.ToString();
                        }
                        success = _orderService.CreateOrder(_order);
                    }

                    if (success)
                    {
                        OrderSaved?.Invoke(this, _order);
                        MessageBox.Show("Заказ успешно сохранен", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateAndUpdateOrder()
        {
            try
            {
                if (!string.IsNullOrEmpty(codeTextBox.Text))
                {
                    if (int.TryParse(codeTextBox.Text, out int code) && code > 0)
                    {
                        _order.Code = code;
                    }
                    else
                    {
                        MessageBox.Show("Артикул должен быть положительным числом", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                _order.Status = statusComboBox.Text?.Trim();
                if (string.IsNullOrEmpty(_order.Status))
                {
                    MessageBox.Show("Выберите статус заказа", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (officeIdComboBox.SelectedValue != null)
                {
                    if (officeIdComboBox.SelectedValue is int officeId)
                    {
                        _order.OfficeId = officeId;
                    }
                    else if (int.TryParse(officeIdComboBox.SelectedValue.ToString(), out int parsedOfficeId))
                    {
                        _order.OfficeId = parsedOfficeId;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите пункт выдачи", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Даты
                _order.OrderDate = orderDateDateTimePicker.Value.Date;
                _order.DeliveryDate = deliveryDateDateTimePicker.Value.Date;

                // Проверяем только если DeliveryDate не минимальная дата
                if (_order.DeliveryDate != DateTime.MinValue && _order.DeliveryDate < _order.OrderDate)
                {
                    MessageBox.Show("Дата доставки не может быть раньше даты заказа", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Пользователь
                if (userIdComboBox.SelectedValue != null)
                {
                    if (userIdComboBox.SelectedValue is int userId)
                    {
                        _order.UserId = userId;
                    }
                    else if (int.TryParse(userIdComboBox.SelectedValue.ToString(), out int parsedUserId))
                    {
                        _order.UserId = parsedUserId;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите пользователя", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при валидации данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить этот заказ?", "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_orderService.DeleteOrder(_order.IdOrder))
                    {
                        OrderSaved?.Invoke(this, _order);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить заказ", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}