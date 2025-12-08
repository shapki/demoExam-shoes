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

        /// <summary>
        /// PKGH: Создание нового заказа с валидацией данных
        /// </summary>
        /// <param name="order">Объект заказа для создания</param>
        /// <returns>True если заказ успешно создан, иначе False</returns>
        public bool CreateOrder(Order order)
        {
            try
            {
                if (!ValidateOrder(order))
                    return false;

                if (order.Code != 0)
                {
                    bool codeExists = _context.Order.Any(o => o.Code == order.Code);
                    if (codeExists)
                    {
                        MessageBox.Show($"Заказ с артикулом '{order.Code}' уже существует", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Артикул не может быть пустым или равным 0", "Ошибка",
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

        /// <summary>
        /// PKGH: Обновление существующего заказа
        /// </summary>
        /// <param name="order">Объект заказа с обновленными данными</param>
        /// <returns>True если заказ успешно обновлен, иначе False</returns>
        public bool UpdateOrder(Order order)
        {
            try
            {
                if (!ValidateOrder(order))
                    return false;

                var existingOrder = _context.Order.Find(order.IdOrder);
                if (existingOrder != null)
                {
                    if (order.Code != 0 && order.Code != existingOrder.Code)
                    {
                        bool codeExists = _context.Order.Any(o => o.Code == order.Code && o.IdOrder != order.IdOrder);
                        if (codeExists)
                        {
                            MessageBox.Show($"Артикул '{order.Code}' уже используется другим заказом", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    _context.Entry(existingOrder).CurrentValues.SetValues(order);
                    _context.SaveChanges();

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

        /// <summary>
        /// PKGH: Удаление заказа с обработкой связанных товаров
        /// </summary>
        /// <param name="orderId">ID заказа для удаления</param>
        /// <returns>True если заказ успешно удален, иначе False</returns>ы
        public bool DeleteOrder(int orderId)
        {
            try
            {
                var order = _context.Order.Find(orderId);
                if (order != null)
                {
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

        /// <summary>
        /// PKGH: Валидация данных заказа перед сохранением
        /// </summary>
        /// <param name="order">Объект заказа для валидации</param>
        /// <returns>True если валидация успешна, иначе False</returns>
        private bool ValidateOrder(Order order)
        {
            if (order.Code <= 0)
            {
                MessageBox.Show("Артикул должен быть положительным числом (больше 0)", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

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