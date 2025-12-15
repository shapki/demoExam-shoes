using shoes.Models;
using shoes.Services;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace shoes.CustomControls
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product;
        private string _role;
        UserRole adminRole = UserRole.Administrator;
        UserRole managerRole = UserRole.Manager;

        public event EventHandler<Product> ProductClicked;

        public ProductUserControl(Product product, string role)
        {
            InitializeComponent();
            _product = product;
            _role = role;
            SetLabelTextValues();
            SetColorByValues();
            SetDiscount();
            LoadProductImage();

            foreach (Control control in this.Controls)
            {
                control.Click += ProductUserControl_Click;
            }
        }

        private void LoadProductImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(_product.Photo))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Resources", _product.Photo);
                    if (File.Exists(imagePath))
                    {
                        productPictureBox.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        productPictureBox.Image = Properties.Resources.picture;
                    }
                }
                else
                {
                    productPictureBox.Image = Properties.Resources.picture;
                }
            }
            catch
            {
                productPictureBox.Image = Properties.Resources.picture;
            }
        }

        private void CheckUserRole()
        {
            if (_role == adminRole.GetDescription() || _role == managerRole.GetDescription())
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
            productNameLabel.Text = _product.ProductCat + " | " + _product.ProductName;

            var SupplyerName = Program.context.Supplyer.FirstOrDefault(e => e.IdSupplyer == _product.SupplyerId);
            if (SupplyerName != null)
                supplyerLabel.Text = "Поставщик: " + SupplyerName.Name;
            else
                supplyerLabel.Text = "Поставщик: ";

            var ManufacturerName = Program.context.Manufacturer.FirstOrDefault(e => e.IdManufacturer == _product.ManufacturerId);
            if (ManufacturerName != null)
                manufacturLabel.Text = "Производитель: " + ManufacturerName.Name;
            else
                manufacturLabel.Text = "Производитель: ";

            priceLabel.Text = "Цена: " + _product.Price;
            stockLabel.Text = "На складе: " + _product.Stock;
            unitLabel.Text = "Единица измерения: " + _product.Unit;
            deskLabel.Text = _product.Desk;
        }

        private void SetColorByValues()
        {
            if (_product.Discount > 15)
            {
                this.BackColor = Color.SeaGreen;
            }
            else if (_product.Stock == 0)
            {
                this.BackColor = Color.Cyan;
            }
        }

        private void SetDiscount()
        {
            if (_product.Discount > 0)
            {
                discountLabel.Text += "\n" + "-" + Convert.ToString(_product.Discount) + "%";
            }
            else
            {
                discountLabel.Text = "Скидки нет";
            }

            double originalPrice = _product.Price;
            double discount = _product.Discount;
            if (discount > 0)
            {
                double discountedAmount = originalPrice * (1.0 - (discount / 100.0));

                priceLabel.Text = $"{originalPrice:C2}";
                priceLabel.ForeColor = Color.Red;
                priceLabel.Font = new Font(priceLabel.Font, FontStyle.Strikeout);

                newPriceLabel.Text = $"{discountedAmount:C2}";
                newPriceLabel.Visible = true;
            }
            else
            {
                priceLabel.Text = $"{originalPrice:C2}";
                priceLabel.ForeColor = Color.Black;
                priceLabel.Font = new Font(priceLabel.Font, FontStyle.Regular);
                priceLabel.Visible = true;

                newPriceLabel.Visible = false;
            }
        }

        private void ProductUserControl_Click(object sender, EventArgs e)
        {
            if (_role == adminRole.GetDescription() || _role == managerRole.GetDescription())
            {
                ProductClicked?.Invoke(this, _product);
            }
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            CheckUserRole();
        }
    }
}
