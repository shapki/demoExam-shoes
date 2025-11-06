
namespace shoes.CustomControls
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.deskLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.supplyerLabel = new System.Windows.Forms.Label();
            this.manufacturLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.scuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.productNameLabel.Location = new System.Drawing.Point(143, 11);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(131, 19);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Название товара";
            // 
            // productPictureBox
            // 
            this.productPictureBox.Image = global::shoes.Properties.Resources.picture;
            this.productPictureBox.Location = new System.Drawing.Point(13, 14);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(124, 134);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 1;
            this.productPictureBox.TabStop = false;
            // 
            // deskLabel
            // 
            this.deskLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.deskLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deskLabel.Location = new System.Drawing.Point(143, 30);
            this.deskLabel.Name = "deskLabel";
            this.deskLabel.Size = new System.Drawing.Size(393, 73);
            this.deskLabel.TabIndex = 2;
            this.deskLabel.Text = "Описание товара";
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceLabel.Location = new System.Drawing.Point(405, 116);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(131, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "??? Р (скидка 0%)";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // supplyerLabel
            // 
            this.supplyerLabel.AutoSize = true;
            this.supplyerLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.supplyerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supplyerLabel.Location = new System.Drawing.Point(144, 116);
            this.supplyerLabel.Name = "supplyerLabel";
            this.supplyerLabel.Size = new System.Drawing.Size(77, 16);
            this.supplyerLabel.TabIndex = 5;
            this.supplyerLabel.Text = "Поставщик:";
            // 
            // manufacturLabel
            // 
            this.manufacturLabel.AutoSize = true;
            this.manufacturLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.manufacturLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manufacturLabel.Location = new System.Drawing.Point(144, 132);
            this.manufacturLabel.Name = "manufacturLabel";
            this.manufacturLabel.Size = new System.Drawing.Size(99, 16);
            this.manufacturLabel.TabIndex = 6;
            this.manufacturLabel.Text = "Производитель:";
            // 
            // stockLabel
            // 
            this.stockLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.stockLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stockLabel.Location = new System.Drawing.Point(420, 132);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(116, 16);
            this.stockLabel.TabIndex = 7;
            this.stockLabel.Text = "Кол-во:";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scuLabel
            // 
            this.scuLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.scuLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scuLabel.Location = new System.Drawing.Point(459, 14);
            this.scuLabel.Name = "scuLabel";
            this.scuLabel.Size = new System.Drawing.Size(77, 16);
            this.scuLabel.TabIndex = 8;
            this.scuLabel.Text = "Артикул";
            this.scuLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Controls.Add(this.scuLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.manufacturLabel);
            this.Controls.Add(this.supplyerLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.deskLabel);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.productNameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.Name = "ProductUserControl";
            this.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Size = new System.Drawing.Size(549, 162);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label deskLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label supplyerLabel;
        private System.Windows.Forms.Label manufacturLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label scuLabel;
    }
}
