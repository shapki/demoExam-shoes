
namespace shoes.AppForms
{
    partial class CreateUpdateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label officeIdLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label userIdLabel;
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.headerSubtitleLabel = new System.Windows.Forms.Label();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.headerLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapkin_DemoShoesDataSet = new shoes.Shapkin_DemoShoesDataSet();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.officeIdComboBox = new System.Windows.Forms.ComboBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.orderTableAdapter = new shoes.Shapkin_DemoShoesDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new shoes.Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager();
            orderDateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            officeIdLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_DemoShoesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            orderDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(66, 89);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(75, 13);
            orderDateLabel.TabIndex = 10;
            orderDateLabel.Text = "Дата заказа:";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(66, 115);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(86, 13);
            deliveryDateLabel.TabIndex = 12;
            deliveryDateLabel.Text = "Дата доставки:";
            // 
            // officeIdLabel
            // 
            officeIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            officeIdLabel.AutoSize = true;
            officeIdLabel.Location = new System.Drawing.Point(66, 61);
            officeIdLabel.Name = "officeIdLabel";
            officeIdLabel.Size = new System.Drawing.Size(80, 13);
            officeIdLabel.TabIndex = 14;
            officeIdLabel.Text = "Пункт выдачи:";
            // 
            // codeLabel
            // 
            codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(66, 8);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(51, 13);
            codeLabel.TabIndex = 16;
            codeLabel.Text = "Артикул:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(66, 34);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(44, 13);
            statusLabel.TabIndex = 18;
            statusLabel.Text = "Статус:";
            // 
            // userIdLabel
            // 
            userIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(66, 138);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(83, 13);
            userIdLabel.TabIndex = 25;
            userIdLabel.Text = "Пользователь:";
            // 
            // formSplitContainer
            // 
            this.formSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.formSplitContainer.IsSplitterFixed = true;
            this.formSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.formSplitContainer.Name = "formSplitContainer";
            this.formSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // formSplitContainer.Panel1
            // 
            this.formSplitContainer.Panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.formSplitContainer.Panel1.Controls.Add(this.headerSubtitleLabel);
            this.formSplitContainer.Panel1.Controls.Add(this.headerTitleLabel);
            this.formSplitContainer.Panel1.Controls.Add(this.headerLogoPictureBox);
            this.formSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // formSplitContainer.Panel2
            // 
            this.formSplitContainer.Panel2.AutoScroll = true;
            this.formSplitContainer.Panel2.Controls.Add(userIdLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.userIdComboBox);
            this.formSplitContainer.Panel2.Controls.Add(orderDateLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.orderDateDateTimePicker);
            this.formSplitContainer.Panel2.Controls.Add(deliveryDateLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.deliveryDateDateTimePicker);
            this.formSplitContainer.Panel2.Controls.Add(officeIdLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.officeIdComboBox);
            this.formSplitContainer.Panel2.Controls.Add(codeLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.codeTextBox);
            this.formSplitContainer.Panel2.Controls.Add(statusLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.statusComboBox);
            this.formSplitContainer.Panel2.Controls.Add(this.saveButton);
            this.formSplitContainer.Size = new System.Drawing.Size(376, 281);
            this.formSplitContainer.SplitterDistance = 80;
            this.formSplitContainer.TabIndex = 5;
            // 
            // headerSubtitleLabel
            // 
            this.headerSubtitleLabel.AutoSize = true;
            this.headerSubtitleLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerSubtitleLabel.Location = new System.Drawing.Point(81, 46);
            this.headerSubtitleLabel.Name = "headerSubtitleLabel";
            this.headerSubtitleLabel.Size = new System.Drawing.Size(142, 16);
            this.headerSubtitleLabel.TabIndex = 2;
            this.headerSubtitleLabel.Text = "Редактирование заказа";
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.AutoSize = true;
            this.headerTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerTitleLabel.Location = new System.Drawing.Point(81, 23);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(141, 23);
            this.headerTitleLabel.TabIndex = 1;
            this.headerTitleLabel.Text = "ООО \"Обувь\"";
            // 
            // headerLogoPictureBox
            // 
            this.headerLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerLogoPictureBox.Image = global::shoes.Properties.Resources.Icon2;
            this.headerLogoPictureBox.Location = new System.Drawing.Point(5, 5);
            this.headerLogoPictureBox.Name = "headerLogoPictureBox";
            this.headerLogoPictureBox.Size = new System.Drawing.Size(70, 70);
            this.headerLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerLogoPictureBox.TabIndex = 0;
            this.headerLogoPictureBox.TabStop = false;
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "UserId", true));
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.Location = new System.Drawing.Point(158, 135);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(144, 21);
            this.userIdComboBox.TabIndex = 26;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.shapkin_DemoShoesDataSet;
            // 
            // shapkin_DemoShoesDataSet
            // 
            this.shapkin_DemoShoesDataSet.DataSetName = "Shapkin_DemoShoesDataSet";
            this.shapkin_DemoShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(158, 83);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.orderDateDateTimePicker.TabIndex = 11;
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "UserId", true));
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(158, 109);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.deliveryDateDateTimePicker.TabIndex = 13;
            // 
            // officeIdComboBox
            // 
            this.officeIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.officeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OfficeId", true));
            this.officeIdComboBox.FormattingEnabled = true;
            this.officeIdComboBox.Location = new System.Drawing.Point(158, 56);
            this.officeIdComboBox.Name = "officeIdComboBox";
            this.officeIdComboBox.Size = new System.Drawing.Size(144, 21);
            this.officeIdComboBox.TabIndex = 15;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(158, 3);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(144, 20);
            this.codeTextBox.TabIndex = 17;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(158, 29);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(144, 21);
            this.statusComboBox.TabIndex = 19;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.LightGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.saveButton.Location = new System.Drawing.Point(69, 162);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(233, 22);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SupplyerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shoes.Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // CreateUpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 281);
            this.Controls.Add(this.formSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(392, 320);
            this.Name = "CreateUpdateOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Обувь\" | ";
            this.Load += new System.EventHandler(this.CreateUpdateOrderForm_Load);
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel1.PerformLayout();
            this.formSplitContainer.Panel2.ResumeLayout(false);
            this.formSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_DemoShoesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.Label headerSubtitleLabel;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.PictureBox headerLogoPictureBox;
        private System.Windows.Forms.Button saveButton;
        private Shapkin_DemoShoesDataSet shapkin_DemoShoesDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Shapkin_DemoShoesDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.ComboBox officeIdComboBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox userIdComboBox;
    }
}