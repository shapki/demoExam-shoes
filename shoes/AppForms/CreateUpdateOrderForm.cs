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
    public partial class CreateUpdateOrderForm : Form
    {
        public CreateUpdateOrderForm()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_DemoShoesDataSet);

        }

        private void CreateUpdateOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_DemoShoesDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.shapkin_DemoShoesDataSet.Order);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
