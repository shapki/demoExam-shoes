using shoes.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace shoes.Services
{
    public class OrderService
    {
        private readonly ShoesModel _context;

        public OrderService(ShoesModel context)
        {
            _context = context;
        }

        public bool CreateOrder(Order order)
        {
            try
            {
                if (!ValidateOrder(order))
                    return false;

                if (order.Code != 0 && _context.Order.Any(o => o.Code == order.Code))
                {
                    MessageBox.Show("Заказ с таким артикулом уже существует", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                _context.Order.Add(order);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateOrder(Order order)
        {
            try
            {
                if (!ValidateOrder(order))
                    return false;

                var existingOrder = _context.Order.Find(order.IdOrder);
                if (existingOrder != null)
                {
                    if (order.Code == 0)
                    {
                        order.Code = existingOrder.Code;
                    }

                    _context.Entry(existingOrder).CurrentValues.SetValues(order);
                    _context.SaveChanges();

                    MessageBox.Show("Заказ успешно обновлен", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                MessageBox.Show("Заказ не найден", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(e => e.ValidationErrors)
                    .Select(e => $"{e.PropertyName}: {e.ErrorMessage}");

                MessageBox.Show($"Ошибки валидации:\n{string.Join("\n", errorMessages)}",
                    "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteOrder(int orderId)
        {
            try
            {
                var order = _context.Order.Find(orderId);
                if (order != null)
                {
                    var hasProducts = _context.OrderProduct.Any(op => op.OrderId == orderId);

                    if (hasProducts)
                    {
                        var result = MessageBox.Show(
                            "У этого заказа есть связанные товары. Удалить заказ вместе с товарами?",
                            "Подтверждение удаления",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            var orderProducts = _context.OrderProduct.Where(op => op.OrderId == orderId).ToList();
                            _context.OrderProduct.RemoveRange(orderProducts);
                        }
                        else
                        {
                            return false;
                        }
                    }

                    _context.Order.Remove(order);
                    _context.SaveChanges();

                    MessageBox.Show("Заказ успешно удален", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                MessageBox.Show("Заказ не найден", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Order GetOrderById(int orderId)
        {
            try
            {
                return _context.Order
                    .Include("Office")
                    .Include("User")
                    .FirstOrDefault(o => o.IdOrder == orderId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IQueryable<Order> GetAllOrders()
        {
            return _context.Order
                .Include("Office")
                .Include("User")
                .OrderByDescending(o => o.OrderDate);
        }

        public IQueryable<Order> GetOrdersByStatus(string status)
        {
            return _context.Order
                .Include("Office")
                .Include("User")
                .Where(o => o.Status == status)
                .OrderByDescending(o => o.OrderDate);
        }

        public IQueryable<Order> GetOrdersByUserId(int userId)
        {
            return _context.Order
                .Include("Office")
                .Include("User")
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.OrderDate);
        }

        public IQueryable<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.Order
                .Include("Office")
                .Include("User")
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .OrderByDescending(o => o.OrderDate);
        }

        private bool ValidateOrder(Order order)
        {
            if (string.IsNullOrWhiteSpace(order.Status))
            {
                MessageBox.Show("Статус заказа не может быть пустым", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (order.OfficeId <= 0)
            {
                MessageBox.Show("Выберите пункт выдачи", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (order.UserId <= 0)
            {
                MessageBox.Show("Выберите пользователя", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (order.OrderDate == DateTime.MinValue)
            {
                MessageBox.Show("Укажите дату заказа", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (order.DeliveryDate != DateTime.MinValue && order.DeliveryDate < order.OrderDate)
            {
                MessageBox.Show("Дата доставки не может быть раньше даты заказа", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var officeExists = _context.Office.Any(o => o.IdOffice == order.OfficeId);
            if (!officeExists)
            {
                MessageBox.Show("Выбранный пункт выдачи не существует", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var userExists = _context.User.Any(u => u.IdUser == order.UserId);
            if (!userExists)
            {
                MessageBox.Show("Выбранный пользователь не существует", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}