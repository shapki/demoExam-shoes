using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using shoes.Models;
using shoes.Services;

namespace shoes.AppForms
{
    public partial class CreateUpdateProductForm : Form
    {
        private Product _product;
        private bool _isEditMode;
        private ProductService _productService;
        private string _tempImagePath;

        public event EventHandler<Product> ProductSaved;

        public CreateUpdateProductForm()
        {
            InitializeComponent();
            _isEditMode = false;
            _productService = new ProductService(Program.context);
            InitializeForm();
        }

        public CreateUpdateProductForm(Product product)
        {
            InitializeComponent();
            _product = product;
            _isEditMode = true;
            _productService = new ProductService(Program.context);
            InitializeForm();
        }

        private void InitializeForm()
        {
            saveButton.Visible = true;
            loadImageButton.Visible = true;
            if (_isEditMode)
            {
                this.Text += "Редактирование товара";
                headerSubtitleLabel.Text = "Редактировние товара";
                deleteProductButton.Visible = true;
                LoadComboBoxData();
                BindProductToControls();
                LoadProductImage();
            }
            else
            {
                this.Text += "Создание товара";
                headerSubtitleLabel.Text = "Создание товара";
                deleteProductButton.Visible = false;
                saveButton.Text = "Добавить товар";
                saveButton.Size = new System.Drawing.Size(225, 24);
                _product = new Product();
                LoadComboBoxData();
            }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            string selectedImagePath = ImageService.OpenImageDialog();

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                try
                {
                    if (!ImageService.IsValidImageFormat(selectedImagePath))
                    {
                        MessageBox.Show("Выберите файл в формате JPG, PNG, GIF или BMP",
                            "Недопустимый формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FileInfo fileInfo = new FileInfo(selectedImagePath);
                    if (fileInfo.Length > 5 * 1024 * 1024)
                    {
                        MessageBox.Show("Размер файла не должен превышать 5 МБ",
                            "Слишком большой файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var tempImage = Image.FromFile(selectedImagePath))
                    {
                        productPictureBox.Image = new Bitmap(tempImage);
                    }

                    _tempImagePath = selectedImagePath;

                    MessageBox.Show("Изображение загружено. Сохраните товар для применения изменений.",
                        "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Невозможно загрузить изображение. Возможно, файл поврежден или имеет недопустимый формат.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearImageButton_Click(object sender, EventArgs e)
        {
            if (productPictureBox.Image != null)
            {
                productPictureBox.Image.Dispose();
                productPictureBox.Image = null;
            }
            _tempImagePath = null;
        }

        private void LoadProductImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(_product.Photo))
                {
                    Image loadedImage = ImageService.LoadProductImage(_product.Photo);
                    if (loadedImage != null)
                    {
                        if (productPictureBox.Image != null)
                        {
                            productPictureBox.Image.Dispose();
                        }
                        productPictureBox.Image = loadedImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool SaveProductImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(_tempImagePath))
                {
                    string oldImageFileName = _isEditMode ? _product.Photo : null;

                    try
                    {
                        _product.Photo = ImageService.SaveProductImage(_tempImagePath, oldImageFileName);
                        _tempImagePath = null;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изображения: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при работе с изображением: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoadComboBoxData()
        {
            var suppliers = Program.context.Supplyer
                .OrderBy(s => s.Name)
                .ToList();

            supplyerIdComboBox.DataSource = suppliers;
            supplyerIdComboBox.DisplayMember = "Name";
            supplyerIdComboBox.ValueMember = "IdSupplyer";

            var manufacturers = Program.context.Manufacturer
                .OrderBy(m => m.Name)
                .ToList();

            manufacturerIdComboBox.DataSource = manufacturers;
            manufacturerIdComboBox.DisplayMember = "Name";
            manufacturerIdComboBox.ValueMember = "IdManufacturer";

            var categories = Program.context.Product
                .Where(p => p.ProductCat != null)
                .Select(p => p.ProductCat)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            productCatComboBox.DataSource = categories;

            var units = Program.context.Product
                .Where(p => !string.IsNullOrEmpty(p.Unit))
                .Select(p => p.Unit)
                .Distinct()
                .OrderBy(u => u)
                .ToList();

            if (!units.Any())
            {
                units = new List<string> { "шт.", "пара", "комплект", "упаковка" };
            }

            unitComboBox.DataSource = units;
        }

        private void BindProductToControls()
        {
            if (_product != null)
            {
                productNameTextBox.Text = _product.ProductName;

                if (!string.IsNullOrEmpty(_product.ProductCat))
                {
                    productCatComboBox.SelectedItem = _product.ProductCat;
                }

                deskTextBox.Text = _product.Desk;

                if (_product.SupplyerId > 0)
                {
                    var supplier = Program.context.Supplyer.Find(_product.SupplyerId);
                    if (supplier != null)
                    {
                        supplyerIdComboBox.SelectedValue = _product.SupplyerId;
                    }
                }

                if (_product.ManufacturerId > 0)
                {
                    var manufacturer = Program.context.Manufacturer.Find(_product.ManufacturerId);
                    if (manufacturer != null)
                    {
                        manufacturerIdComboBox.SelectedValue = _product.ManufacturerId;
                    }
                }

                priceTextBox.Text = _product.Price.ToString();
                stockTextBox.Text = _product.Stock.ToString();

                if (!string.IsNullOrEmpty(_product.Unit))
                {
                    unitComboBox.SelectedItem = _product.Unit;
                }
                else if (unitComboBox.Items.Count > 0)
                {
                    unitComboBox.SelectedIndex = 0;
                }

                discountTextBox.Text = _product.Discount.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (UpdateProductFromControls())
            {
                bool success = false;

                try
                {
                    if (_isEditMode)
                    {
                        success = _productService.UpdateProduct(_product);
                    }
                    else
                    {
                        success = _productService.CreateProduct(_product);
                    }

                    if (success)
                    {
                        ProductSaved?.Invoke(this, _product);
                        this.Close();
                    }
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    var errorMessages = new List<string>();
                    foreach (var validationResult in ex.EntityValidationErrors)
                    {
                        foreach (var error in validationResult.ValidationErrors)
                        {
                            errorMessages.Add($"{error.PropertyName}: {error.ErrorMessage}");
                        }
                    }
                    MessageBox.Show($"Ошибки валидации:\n{string.Join("\n", errorMessages)}",
                        "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if (_productService.DeleteProduct(_product.IdProduct))
                {
                    ProductSaved?.Invoke(this, _product);
                    this.Close();
                }
            }
        }

        private bool UpdateProductFromControls()
        {
            try
            {
                if (!_isEditMode)
                {
                    _product.Scu = GenerateNewScu();
                }

                _product.ProductName = productNameTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(productCatComboBox.Text))
                {
                    _product.ProductCat = productCatComboBox.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Введите категорию товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                _product.Desk = deskTextBox.Text.Trim();
                _product.Unit = unitComboBox.Text.Trim();

                if (!string.IsNullOrEmpty(supplyerIdComboBox.Text))
                {
                    var supplierName = supplyerIdComboBox.Text.Trim();
                    var existingSupplier = Program.context.Supplyer.FirstOrDefault(s => s.Name == supplierName);

                    if (existingSupplier != null)
                    {
                        _product.SupplyerId = existingSupplier.IdSupplyer;
                    }
                    else
                    {
                        if (supplierName.Length <= 70)
                        {
                            var newSupplier = new Supplyer { Name = supplierName };
                            Program.context.Supplyer.Add(newSupplier);
                            Program.context.SaveChanges();
                            _product.SupplyerId = newSupplier.IdSupplyer;

                            LoadComboBoxData();
                            supplyerIdComboBox.SelectedValue = newSupplier.IdSupplyer;
                        }
                        else
                        {
                            MessageBox.Show("Название поставщика слишком длинное (максимум 70 символов)",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите или выберите поставщика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!string.IsNullOrEmpty(manufacturerIdComboBox.Text))
                {
                    var manufacturerName = manufacturerIdComboBox.Text.Trim();
                    var existingManufacturer = Program.context.Manufacturer.FirstOrDefault(m => m.Name == manufacturerName);

                    if (existingManufacturer != null)
                    {
                        _product.ManufacturerId = existingManufacturer.IdManufacturer;
                    }
                    else
                    {
                        if (manufacturerName.Length <= 70)
                        {
                            var newManufacturer = new Manufacturer { Name = manufacturerName };
                            Program.context.Manufacturer.Add(newManufacturer);
                            Program.context.SaveChanges();
                            _product.ManufacturerId = newManufacturer.IdManufacturer;

                            LoadComboBoxData();
                            manufacturerIdComboBox.SelectedValue = newManufacturer.IdManufacturer;
                        }
                        else
                        {
                            MessageBox.Show("Название производителя слишком длинное (максимум 70 символов)",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите или выберите производителя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (double.TryParse(priceTextBox.Text, out double price) && price > 0)
                {
                    _product.Price = price;
                }
                else
                {
                    MessageBox.Show("Введите корректную цену (положительное число)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (int.TryParse(stockTextBox.Text, out int stock) && stock >= 0)
                {
                    _product.Stock = stock;
                }
                else
                {
                    MessageBox.Show("Введите корректное количество (целое неотрицательное число)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (double.TryParse(discountTextBox.Text, out double discount) && discount >= 0 && discount <= 100)
                {
                    _product.Discount = discount;
                }
                else
                {
                    MessageBox.Show("Введите корректную скидку (число от 0 до 100)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!string.IsNullOrEmpty(_tempImagePath))
                {
                    string oldImageFileName = _isEditMode ? _product.Photo : null;
                    _product.Photo = ImageService.SaveProductImage(_tempImagePath, oldImageFileName);
                    _tempImagePath = null;
                }
                else if (productPictureBox.Image == null && _isEditMode && !string.IsNullOrEmpty(_product.Photo))
                {
                    ImageService.DeleteProductImage(_product.Photo);
                    _product.Photo = null;
                }

                if (!string.IsNullOrEmpty(unitComboBox.Text))
                {
                    _product.Unit = unitComboBox.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Введите единицу измерения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// PKGH: Генерация уникального артикула для нового товара
        /// </summary>
        /// <returns>Сгенерированный уникальный артикул</returns>
        private string GenerateNewScu()
        {
            var random = new Random();
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";

            string GenerateScu()
            {
                char firstLetter = letters[random.Next(letters.Length)];
                string threeDigits = new string(Enumerable.Repeat(digits, 3)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                char secondLetter = letters[random.Next(letters.Length)];
                char lastDigit = digits[random.Next(digits.Length)];

                return $"{firstLetter}{threeDigits}{secondLetter}{lastDigit}";
            }

            string newScu = GenerateScu();

            int attempts = 0;
            while (Program.context.Product.Any(p => p.Scu == newScu) && attempts < 20)
            {
                newScu = GenerateScu();
                attempts++;
            }

            if (attempts >= 20)
            {
                string timestamp = DateTime.Now.ToString("fff");
                newScu = $"{letters[random.Next(letters.Length)]}{timestamp}{letters[random.Next(letters.Length)]}{random.Next(10)}";

                if (newScu.Length > 6)
                    newScu = newScu.Substring(0, 6);
            }

            return newScu;
        }

        private void CreateUpdateProductForm_Load(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                LoadComboBoxData();
            }
        }
    }
}