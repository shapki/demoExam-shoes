using System;
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
            discountLabel.Text = Convert.ToString(_product.Discount) + "%";
        }

        private void ProductUserControl_Click(object sender, EventArgs e)
        {

        }
    }
}
