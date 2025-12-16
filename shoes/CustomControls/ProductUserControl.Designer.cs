
namespace shoes.CustomControls
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.unitLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.newPriceLabel = new System.Windows.Forms.Label();
            this.infoBackPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.productNameLabel.Location = new System.Drawing.Point(144, 12);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(273, 19);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Категория Товара | Название товара";
            // 
            // productPictureBox
            // 
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPictureBox.Image = global::shoes.Properties.Resources.picture;
            this.productPictureBox.Location = new System.Drawing.Point(13, 11);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(124, 117);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 1;
            this.productPictureBox.TabStop = false;
            // 
            // deskLabel
            // 
            this.deskLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.deskLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deskLabel.Location = new System.Drawing.Point(144, 30);
            this.deskLabel.Name = "deskLabel";
            this.deskLabel.Size = new System.Drawing.Size(388, 21);
            this.deskLabel.TabIndex = 2;
            this.deskLabel.Text = "Описание товара";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceLabel.Location = new System.Drawing.Point(144, 78);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Цена: ";
            // 
            // supplyerLabel
            // 
            this.supplyerLabel.AutoSize = true;
            this.supplyerLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.supplyerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supplyerLabel.Location = new System.Drawing.Point(144, 62);
            this.supplyerLabel.Name = "supplyerLabel";
            this.supplyerLabel.Size = new System.Drawing.Size(81, 16);
            this.supplyerLabel.TabIndex = 5;
            this.supplyerLabel.Text = "Поставщик: ";
            // 
            // manufacturLabel
            // 
            this.manufacturLabel.AutoSize = true;
            this.manufacturLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.manufacturLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manufacturLabel.Location = new System.Drawing.Point(144, 46);
            this.manufacturLabel.Name = "manufacturLabel";
            this.manufacturLabel.Size = new System.Drawing.Size(103, 16);
            this.manufacturLabel.TabIndex = 6;
            this.manufacturLabel.Text = "Производитель: ";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.stockLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stockLabel.Location = new System.Drawing.Point(144, 110);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(144, 16);
            this.stockLabel.TabIndex = 7;
            this.stockLabel.Text = "Количество на складе: ";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.unitLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unitLabel.Location = new System.Drawing.Point(144, 94);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(129, 16);
            this.unitLabel.TabIndex = 8;
            this.unitLabel.Text = "Единица измерения: ";
            // 
            // discountLabel
            // 
            this.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.discountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.discountLabel.Location = new System.Drawing.Point(542, 11);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(102, 117);
            this.discountLabel.TabIndex = 9;
            this.discountLabel.Text = "Действующая скидка:";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPriceLabel
            // 
            this.newPriceLabel.AutoSize = true;
            this.newPriceLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.newPriceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newPriceLabel.Location = new System.Drawing.Point(230, 78);
            this.newPriceLabel.Name = "newPriceLabel";
            this.newPriceLabel.Size = new System.Drawing.Size(43, 16);
            this.newPriceLabel.TabIndex = 10;
            this.newPriceLabel.Text = "Цена: ";
            this.newPriceLabel.Visible = false;
            // 
            // infoBackPanel
            // 
            this.infoBackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBackPanel.Location = new System.Drawing.Point(143, 11);
            this.infoBackPanel.Name = "infoBackPanel";
            this.infoBackPanel.Size = new System.Drawing.Size(393, 117);
            this.infoBackPanel.TabIndex = 11;
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.newPriceLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.manufacturLabel);
            this.Controls.Add(this.supplyerLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.deskLabel);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.infoBackPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.Name = "ProductUserControl";
            this.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Size = new System.Drawing.Size(654, 139);
            this.Load += new System.EventHandler(this.ProductUserControl_Load);
            this.Click += new System.EventHandler(this.ProductUserControl_Click);
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
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label newPriceLabel;
        private System.Windows.Forms.Panel infoBackPanel;
    }
}
