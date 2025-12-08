using System;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PKGH: Установка заголовка формы и подзаголовка
        /// </summary>
        /// <param name="subtitle">Подзаголовок для отображения</param>
        protected void SetTitle(string subtitle)
        {
            this.Text = $"ООО \"Обувь\" | {subtitle}";
            headerSubtitleLabel.Text = subtitle;
        }
    }
}