using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using shoes.Models;

namespace shoes.CustomControls
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product;
        public ProductUserControl(Product product)
        {
            InitializeComponent();
            _product = product;
            SetLabelTextValues();
            SetColorByValues();
            SetDiscount();
        }

        private void SetLabelTextValues()
        {
            productNameLabel.Text = _product.ProductCat + " | " + _product.ProductName;

            var SupplyerName = Program.context.Supplyer.FirstOrDefault(e => e.IdSupplyer == _product.SupplyerId);
            if (SupplyerName != null)
                supplyerLabel.Text += SupplyerName.Name;
            else
                supplyerLabel.Text += "";

            var ManufacturerName = Program.context.Manufacturer.FirstOrDefault(e => e.IdManufacturer == _product.ManufacturerId);
            if (ManufacturerName != null)
                manufacturLabel.Text += ManufacturerName.Name;
            else
                manufacturLabel.Text += "";

            priceLabel.Text += _product.Price;
            stockLabel.Text += _product.Stock;
            unitLabel.Text += _product.Unit;
            deskLabel.Text = _product.Desk;

            if (_product.Discount > 0)
            {
                discountLabel.Text += "\n" + Convert.ToString(_product.Discount) + "%";
            } else
            {
                discountLabel.Text = "Скидки нет";
            }


            string fileName = _product.Photo;
            string baseDirectory = @"X:\Инструментальные средства разработки программного обеспечения (МДК.02.02)\demoExam\shoes\shoes\Resources";
            if (!string.IsNullOrEmpty(fileName))
            {
                string fullPath = Path.Combine(baseDirectory, fileName);
                if (File.Exists(fullPath))
                {
                    productPictureBox.ImageLocation = fullPath;
                }
            }
        }

        private void SetColorByValues()
        {
            if (_product.Discount >= 15)
            {
                this.BackColor = Color.SeaGreen;
            } else if (_product.Stock == 0)
            {
                this.BackColor = Color.Cyan;
            }
        }

        private void SetDiscount()
        {
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

        }
    }
}
