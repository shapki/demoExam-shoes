using System;
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
            productNameLabel.Text = _product.ProductName;
            scuLabel.Text = _product.Scu;
            supplyerLabel.Text += _product.Supplyer;
            manufacturLabel.Text += _product.Manufacturer;
            priceLabel.Text = _product.Price + " Р";
            stockLabel.Text = _product.Stock + " " + _product.Unit;
            deskLabel.Text = _product.Desk;
        }
    }
}
