
using System.Windows.Forms;

namespace shoes.AppForms
{
    partial class CreateUpdateProductForm
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
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label supplyerIdLabel;
            System.Windows.Forms.Label manufacturerIdLabel;
            System.Windows.Forms.Label productCatLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label deskLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateProductForm));
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.headerSubtitleLabel = new System.Windows.Forms.Label();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.headerLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapkin_DemoShoesDataSet = new shoes.Shapkin_DemoShoesDataSet();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.supplyerIdComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerIdComboBox = new System.Windows.Forms.ComboBox();
            this.productCatComboBox = new System.Windows.Forms.ComboBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.deskTextBox = new System.Windows.Forms.TextBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.clearImageButton = new System.Windows.Forms.Button();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.productTableAdapter = new shoes.Shapkin_DemoShoesDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new shoes.Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager();
            productNameLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            supplyerIdLabel = new System.Windows.Forms.Label();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            productCatLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            deskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_DemoShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.imageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            productNameLabel.Location = new System.Drawing.Point(79, 12);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(93, 15);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Наименование:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            unitLabel.Location = new System.Drawing.Point(80, 184);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(89, 15);
            unitLabel.TabIndex = 2;
            unitLabel.Text = "Ед. измерения:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            priceLabel.Location = new System.Drawing.Point(80, 156);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(38, 15);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Цена:";
            // 
            // supplyerIdLabel
            // 
            supplyerIdLabel.AutoSize = true;
            supplyerIdLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            supplyerIdLabel.Location = new System.Drawing.Point(80, 98);
            supplyerIdLabel.Name = "supplyerIdLabel";
            supplyerIdLabel.Size = new System.Drawing.Size(94, 15);
            supplyerIdLabel.TabIndex = 6;
            supplyerIdLabel.Text = "Производитель:";
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            manufacturerIdLabel.Location = new System.Drawing.Point(80, 127);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(72, 15);
            manufacturerIdLabel.TabIndex = 8;
            manufacturerIdLabel.Text = "Поставщик:";
            // 
            // productCatLabel
            // 
            productCatLabel.AutoSize = true;
            productCatLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            productCatLabel.Location = new System.Drawing.Point(79, 40);
            productCatLabel.Name = "productCatLabel";
            productCatLabel.Size = new System.Drawing.Size(67, 15);
            productCatLabel.TabIndex = 10;
            productCatLabel.Text = "Категория:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            discountLabel.Location = new System.Drawing.Point(80, 240);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(49, 15);
            discountLabel.TabIndex = 12;
            discountLabel.Text = "Скидка:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            stockLabel.Location = new System.Drawing.Point(80, 212);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(102, 15);
            stockLabel.TabIndex = 14;
            stockLabel.Text = "Кол-во на складе:";
            // 
            // deskLabel
            // 
            deskLabel.AutoSize = true;
            deskLabel.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            deskLabel.Location = new System.Drawing.Point(80, 70);
            deskLabel.Name = "deskLabel";
            deskLabel.Size = new System.Drawing.Size(65, 15);
            deskLabel.TabIndex = 16;
            deskLabel.Text = "Описание:";
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
            this.formSplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.formSplitContainer.Panel2.Controls.Add(this.unitComboBox);
            this.formSplitContainer.Panel2.Controls.Add(this.deleteProductButton);
            this.formSplitContainer.Panel2.Controls.Add(this.saveButton);
            this.formSplitContainer.Panel2.Controls.Add(productNameLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.productNameTextBox);
            this.formSplitContainer.Panel2.Controls.Add(unitLabel);
            this.formSplitContainer.Panel2.Controls.Add(priceLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.priceTextBox);
            this.formSplitContainer.Panel2.Controls.Add(supplyerIdLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.supplyerIdComboBox);
            this.formSplitContainer.Panel2.Controls.Add(manufacturerIdLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.manufacturerIdComboBox);
            this.formSplitContainer.Panel2.Controls.Add(productCatLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.productCatComboBox);
            this.formSplitContainer.Panel2.Controls.Add(discountLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.discountTextBox);
            this.formSplitContainer.Panel2.Controls.Add(stockLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.stockTextBox);
            this.formSplitContainer.Panel2.Controls.Add(deskLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.deskTextBox);
            this.formSplitContainer.Panel2.Controls.Add(this.imageGroupBox);
            this.formSplitContainer.Size = new System.Drawing.Size(376, 430);
            this.formSplitContainer.SplitterDistance = 80;
            this.formSplitContainer.TabIndex = 4;
            // 
            // headerSubtitleLabel
            // 
            this.headerSubtitleLabel.AutoSize = true;
            this.headerSubtitleLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerSubtitleLabel.Location = new System.Drawing.Point(81, 50);
            this.headerSubtitleLabel.Name = "headerSubtitleLabel";
            this.headerSubtitleLabel.Size = new System.Drawing.Size(143, 16);
            this.headerSubtitleLabel.TabIndex = 2;
            this.headerSubtitleLabel.Text = "Редактирование товара";
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.AutoSize = true;
            this.headerTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerTitleLabel.Location = new System.Drawing.Point(81, 25);
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
            // unitComboBox
            // 
            this.unitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Unit", true));
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "шт."});
            this.unitComboBox.Location = new System.Drawing.Point(184, 182);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(121, 22);
            this.unitComboBox.TabIndex = 22;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.shapkin_DemoShoesDataSet;
            // 
            // shapkin_DemoShoesDataSet
            // 
            this.shapkin_DemoShoesDataSet.DataSetName = "Shapkin_DemoShoesDataSet";
            this.shapkin_DemoShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductButton.BackColor = System.Drawing.Color.Red;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteProductButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.deleteProductButton.ForeColor = System.Drawing.Color.White;
            this.deleteProductButton.Location = new System.Drawing.Point(179, 447);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(109, 24);
            this.deleteProductButton.TabIndex = 20;
            this.deleteProductButton.Text = "Удалить товар";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Visible = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.saveButton.Location = new System.Drawing.Point(80, 447);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 24);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить изм.";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.productNameTextBox.Location = new System.Drawing.Point(184, 9);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.productNameTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.priceTextBox.Location = new System.Drawing.Point(184, 152);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 5;
            // 
            // supplyerIdComboBox
            // 
            this.supplyerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "SupplyerId", true));
            this.supplyerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplyerIdComboBox.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.supplyerIdComboBox.FormattingEnabled = true;
            this.supplyerIdComboBox.Location = new System.Drawing.Point(184, 94);
            this.supplyerIdComboBox.Name = "supplyerIdComboBox";
            this.supplyerIdComboBox.Size = new System.Drawing.Size(121, 23);
            this.supplyerIdComboBox.TabIndex = 7;
            // 
            // manufacturerIdComboBox
            // 
            this.manufacturerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerId", true));
            this.manufacturerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerIdComboBox.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.manufacturerIdComboBox.FormattingEnabled = true;
            this.manufacturerIdComboBox.Location = new System.Drawing.Point(184, 123);
            this.manufacturerIdComboBox.Name = "manufacturerIdComboBox";
            this.manufacturerIdComboBox.Size = new System.Drawing.Size(121, 23);
            this.manufacturerIdComboBox.TabIndex = 9;
            // 
            // productCatComboBox
            // 
            this.productCatComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCat", true));
            this.productCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCatComboBox.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.productCatComboBox.FormattingEnabled = true;
            this.productCatComboBox.Location = new System.Drawing.Point(184, 37);
            this.productCatComboBox.Name = "productCatComboBox";
            this.productCatComboBox.Size = new System.Drawing.Size(121, 23);
            this.productCatComboBox.TabIndex = 11;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Discount", true));
            this.discountTextBox.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.discountTextBox.Location = new System.Drawing.Point(184, 236);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(121, 22);
            this.discountTextBox.TabIndex = 13;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Stock", true));
            this.stockTextBox.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.stockTextBox.Location = new System.Drawing.Point(184, 208);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(121, 22);
            this.stockTextBox.TabIndex = 15;
            // 
            // deskTextBox
            // 
            this.deskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Desk", true));
            this.deskTextBox.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.deskTextBox.Location = new System.Drawing.Point(184, 66);
            this.deskTextBox.Name = "deskTextBox";
            this.deskTextBox.Size = new System.Drawing.Size(121, 22);
            this.deskTextBox.TabIndex = 17;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadImageButton.Location = new System.Drawing.Point(10, 150);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(92, 23);
            this.loadImageButton.TabIndex = 23;
            this.loadImageButton.Text = "Загрузить";
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // clearImageButton
            // 
            this.clearImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearImageButton.Location = new System.Drawing.Point(120, 150);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(90, 23);
            this.clearImageButton.TabIndex = 24;
            this.clearImageButton.Text = "Очистить";
            this.clearImageButton.Click += new System.EventHandler(this.clearImageButton_Click);
            // 
            // productPictureBox
            // 
            this.productPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPictureBox.Location = new System.Drawing.Point(10, 20);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(200, 120);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 25;
            this.productPictureBox.TabStop = false;
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.productPictureBox);
            this.imageGroupBox.Controls.Add(this.loadImageButton);
            this.imageGroupBox.Controls.Add(this.clearImageButton);
            this.imageGroupBox.Location = new System.Drawing.Point(80, 264);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(225, 177);
            this.imageGroupBox.TabIndex = 23;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "Изображение товара";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.SupplyerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shoes.Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // CreateUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 430);
            this.Controls.Add(this.formSplitContainer);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(392, 201);
            this.Name = "CreateUpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ООО \"Обувь\" | ";
            this.Load += new System.EventHandler(this.CreateUpdateProductForm_Load);
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel1.PerformLayout();
            this.formSplitContainer.Panel2.ResumeLayout(false);
            this.formSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_DemoShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.imageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.Label headerSubtitleLabel;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.PictureBox headerLogoPictureBox;
        private Shapkin_DemoShoesDataSet shapkin_DemoShoesDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Shapkin_DemoShoesDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox supplyerIdComboBox;
        private System.Windows.Forms.ComboBox manufacturerIdComboBox;
        private System.Windows.Forms.ComboBox productCatComboBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox deskTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button clearImageButton;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.GroupBox imageGroupBox;
    }
}