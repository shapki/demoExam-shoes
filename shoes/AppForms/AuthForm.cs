using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_DemoShoesDataSet);

        }

        private void AuthForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_DemoShoesDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.shapkin_DemoShoesDataSet.User);

        }
    }
}
