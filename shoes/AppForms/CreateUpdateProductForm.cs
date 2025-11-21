using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class CreateUpdateProductForm : Form
    {
        public CreateUpdateProductForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_DemoShoesDataSet);

        }

        private void CreateUpdateProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_DemoShoesDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.shapkin_DemoShoesDataSet.Product);

        }
    }
}
