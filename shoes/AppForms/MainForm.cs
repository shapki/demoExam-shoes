using shoes.CustomControls;
using shoes.Models;
using shoes.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class MainForm : Form
    {
        private string _role;
        private int sortMode = 0;
        private string sortButtonText = "Сортировка по кол-ву ";
        private ProductService _productService;

        UserRole adminRole = UserRole.Administrator;
        UserRole managerRole = UserRole.Manager;

        public MainForm(string fullName, string role)
        {
            InitializeComponent();
            userFullNameLabel.Text = fullName;
            _role = role;
            _productService = new ProductService(Program.context);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            this.supplyerTableAdapter.Fill(this.shapkin_DemoShoesDataSet.Supplyer);
            LoadFilterComboBox();
            ShowProductsFilteredAndSorted();
            CheckUserRole();
        }

        private void CheckUserRole()
        {
            if (_role == adminRole.GetDescription() || _role == managerRole.GetDescription())
            {
                filterComboBox.Visible = true;
                sortButton.Visible = true;
                searchTextBox.Visible = true;
                ordersButton.Visible = true;
                addProductButton.Visible = _role == adminRole.GetDescription();
                formSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            }
            else
            {
                formSplitContainer.SplitterDistance = 70;
            }
        }

        /// <summary>
        /// PKGH: Загрузка и отображение товаров
        /// </summary>ы
        private void ShowProductsFilteredAndSorted()
        {
            using (var context = new ShoesModel())
            {
                var products = GetFilteredProducts(context);
                products = ApplySorting(products);

                contentFlowLayoutPanel.Controls.Clear();

                foreach (Product product in products)
                {
                    var productControl = new ProductUserControl(product, _role);
                    productControl.ProductClicked += ProductControl_ProductClicked;
                    contentFlowLayoutPanel.Controls.Add(productControl);
                }
            }
        }

        /// <summary>
        /// PKGH: Фильтрация товаров по поставщику и поиску
        /// </summary>
        /// <param name="context">Контекст бд</param>
        /// <returns>Отфильтрованный список товаров</returns>
        private List<Product> GetFilteredProducts(ShoesModel context)
        {
            string selectedSupplier = filterComboBox.SelectedItem?.ToString();
            var products = context.Product.AsQueryable();

            if (!string.IsNullOrEmpty(selectedSupplier) && selectedSupplier != "Все поставщики")
            {
                var supplier = context.Supplyer.FirstOrDefault(s => s.Name == selectedSupplier);
                if (supplier != null)
                {
                    products = products.Where(p => p.SupplyerId == supplier.IdSupplyer);
                }
            }

            products = SearchProduct(products);

            return products
                .Include(p => p.Supplyer)
                .Include(p => p.Manufacturer)
                .ToList();
        }

        private void ProductControl_ProductClicked(object sender, Product product)
        {
            var editForm = new CreateUpdateProductForm(product);
            editForm.ProductSaved += (s, updatedProduct) => ShowProductsFilteredAndSorted();
            editForm.ShowDialog();
        }

        private List<Product> GetFilteredProducts()
        {
            string selectedSupplier = filterComboBox.SelectedItem?.ToString();
            var products = Program.context.Product.AsQueryable();

            if (!string.IsNullOrEmpty(selectedSupplier) && selectedSupplier != "Все поставщики")
            {
                var supplier = Program.context.Supplyer.FirstOrDefault(s => s.Name == selectedSupplier);
                if (supplier != null)
                {
                    products = products.Where(p => p.SupplyerId == supplier.IdSupplyer);
                }
            }

            products = SearchProduct(products);

            return products.ToList();
        }

        /// <summary>
        /// PKGH: Поиск товаров по запросу в различных полях
        /// </summary>
        /// <param name="products">Запрос товаров для фильтрации</param>
        /// <returns>Запрос с применённым поиском</returns>
        private IQueryable<Product> SearchProduct(IQueryable<Product> products)
        {
            string searchText = searchTextBox.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
            {
                products = products.Where(p =>
                    (p.ProductName != null && p.ProductName.ToLower().Contains(searchText)) ||
                    (p.ProductCat != null && p.ProductCat.ToLower().Contains(searchText)) ||
                    (p.Desk != null && p.Desk.ToLower().Contains(searchText)) ||
                    (p.Unit != null && p.Unit.ToLower().Contains(searchText)) ||
                    (p.Supplyer != null && p.Supplyer.Name != null && p.Supplyer.Name.ToLower().Contains(searchText)) ||
                    (p.Manufacturer != null && p.Manufacturer.Name != null && p.Manufacturer.Name.ToLower().Contains(searchText))
                );
            }

            return products;
        }

        /// <summary>
        /// PKGH: Применение сортировки к списку товаров
        /// </summary>
        /// <param name="products">Список товаров для сортировки</param>
        /// <returns>Отсортированный список товаров</returns>
        private List<Product> ApplySorting(List<Product> products)
        {
            switch (sortMode)
            {
                case 1:
                    return products
                        .OrderByDescending(p => p.Stock)
                        .ThenBy(p => p.ProductName)
                        .ToList();
                case 2:
                    return products
                        .OrderBy(p => p.Stock)
                        .ThenBy(p => p.ProductName)
                        .ToList();
                default:
                    return products
                        .OrderBy(p => p.ProductName)
                        .ToList();
            }
        }

        private void LoadFilterComboBox()
        {
            filterComboBox.Items.Clear();
            filterComboBox.Items.Add("Все поставщики");

            using (var context = new ShoesModel())
            {
                var suppliers = context.Supplyer.OrderBy(s => s.Name).ToList();
                foreach (var supplier in suppliers)
                {
                    filterComboBox.Items.Add(supplier.Name);
                }
            }

            filterComboBox.SelectedIndex = 0;
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

            ShowProductsFilteredAndSorted();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProductsFilteredAndSorted();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowProductsFilteredAndSorted();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateUpdateProductForm();
            createForm.ProductSaved += (s, product) => ShowProductsFilteredAndSorted();
            createForm.ShowDialog();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrdersForm orderForm = new OrdersForm(_role);
            orderForm.ShowDialog();
        }
    }
}