using shoes.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace shoes.Services
{
    public class ProductService
    {
        private readonly ShoesModel _context;

        public ProductService(ShoesModel context)
        {
            _context = context;
        }

        /// <summary>
        /// PKGH: Создание нового товара с валидацией полей
        /// </summary>
        /// <param name="product">Товар для создания</param>
        /// <returns>True если товар успешно создан, иначе False</returns>
        public bool CreateProduct(Product product)
        {
            try
            {
                if (string.IsNullOrEmpty(product.Scu) || product.Scu.Length > 10)
                {
                    throw new ArgumentException("SCU обязательно и должно быть не длиннее 10 символов");
                }

                if (string.IsNullOrEmpty(product.ProductName) || product.ProductName.Length > 70)
                {
                    throw new ArgumentException("Название товара обязательно и должно быть не длиннее 70 символов");
                }

                if (string.IsNullOrEmpty(product.Unit) || product.Unit.Length > 10)
                {
                    throw new ArgumentException("Единица измерения обязательна и должна быть не длиннее 10 символов");
                }

                if (string.IsNullOrEmpty(product.ProductCat) || product.ProductCat.Length > 70)
                {
                    throw new ArgumentException("Категория обязательна и должна быть не длиннее 70 символов");
                }

                if (string.IsNullOrEmpty(product.Desk) || product.Desk.Length > 550)
                {
                    throw new ArgumentException("Описание обязательно и должно быть не длиннее 550 символов");
                }

                _context.Product.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating product: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// PKGH: Обновление существующего товара
        /// </summary>
        /// <param name="product">Товар с обновлёнными данными</param>
        /// <returns>True если товар успешно обновлен, иначе False</returns>
        public bool UpdateProduct(Product product)
        {
            if (!ValidateProduct(product))
                return false;

            try
            {
                var existingProduct = _context.Product.Find(product.IdProduct);
                if (existingProduct != null)
                {
                    _context.Entry(existingProduct).CurrentValues.SetValues(product);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении товара: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// PKGH: Удаление товара по ID
        /// </summary>
        /// <param name="productId">ID товара для удаления</param>
        /// <returns>True если товар успешно удален, иначе False</returns>
        public bool DeleteProduct(int productId)
        {
            try
            {
                var product = _context.Product.Find(productId);
                if (product != null)
                {
                    if (!string.IsNullOrEmpty(product.Photo))
                    {
                        try
                        {
                            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                "Resources", product.Photo);
                            if (File.Exists(imagePath))
                            {
                                File.Delete(imagePath);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Не удалось удалить изображение товара: {ex.Message}");
                        }
                    }

                    _context.Product.Remove(product);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении товара: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// PKGH: Валидация данных товара перед сохранением
        /// </summary>
        /// <param name="product">Товар для валидации</param>
        /// <returns>True если валидация успешна, иначе False</returns>
        private bool ValidateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName))
            {
                MessageBox.Show("Наименование товара не может быть пустым", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (product.Price <= 0)
            {
                MessageBox.Show("Цена должна быть больше 0", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (product.Stock < 0)
            {
                MessageBox.Show("Количество на складе не может быть отрицательным", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}