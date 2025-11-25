
namespace shoes.CustomControls
{
    partial class OrderUserControl
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
            this.scuLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.officeLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scuLabel
            // 
            this.scuLabel.AutoSize = true;
            this.scuLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.scuLabel.Location = new System.Drawing.Point(23, 20);
            this.scuLabel.Name = "scuLabel";
            this.scuLabel.Size = new System.Drawing.Size(72, 17);
            this.scuLabel.TabIndex = 0;
            this.scuLabel.Text = "Артикул: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.statusLabel.Location = new System.Drawing.Point(22, 37);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 16);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Статус: ";
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.officeLabel.Location = new System.Drawing.Point(23, 53);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(96, 16);
            this.officeLabel.TabIndex = 2;
            this.officeLabel.Text = "Пункт выдачи: ";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.orderDateLabel.Location = new System.Drawing.Point(22, 69);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(87, 16);
            this.orderDateLabel.TabIndex = 3;
            this.orderDateLabel.Text = "Дата заказа:  ";
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryDateLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.deliveryDateLabel.Location = new System.Drawing.Point(520, 20);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(111, 65);
            this.deliveryDateLabel.TabIndex = 4;
            this.deliveryDateLabel.Text = "Дата доставки:\r\n";
            this.deliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.officeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.scuLabel);
            this.Name = "OrderUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(654, 106);
            this.Load += new System.EventHandler(this.OrderUserControl_Load);
            this.Click += new System.EventHandler(this.OrderUserControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scuLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label deliveryDateLabel;
    }
}
