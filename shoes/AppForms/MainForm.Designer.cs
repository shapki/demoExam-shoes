
namespace shoes.AppForms
{
    partial class MainForm
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
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.headerLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.userFullNameLabel = new System.Windows.Forms.Label();
            this.headerSubtitleLabel = new System.Windows.Forms.Label();
            this.contentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.shapkin_DemoShoesDataSet = new shoes.Shapkin_DemoShoesDataSet();
            this.supplyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyerTableAdapter = new shoes.Shapkin_DemoShoesDataSetTableAdapters.SupplyerTableAdapter();
            this.addProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_DemoShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyerBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.formSplitContainer.Panel1.Controls.Add(this.filterComboBox);
            this.formSplitContainer.Panel1.Controls.Add(this.sortButton);
            this.formSplitContainer.Panel1.Controls.Add(this.searchTextBox);
            this.formSplitContainer.Panel1.Controls.Add(this.headerPanel);
            // 
            // formSplitContainer.Panel2
            // 
            this.formSplitContainer.Panel2.Controls.Add(this.contentFlowLayoutPanel);
            this.formSplitContainer.Size = new System.Drawing.Size(678, 450);
            this.formSplitContainer.SplitterDistance = 96;
            this.formSplitContainer.TabIndex = 2;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterComboBox.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterComboBox.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(275, 72);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(114, 23);
            this.filterComboBox.TabIndex = 8;
            this.filterComboBox.Visible = false;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.sortButton.Location = new System.Drawing.Point(395, 72);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(171, 22);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Сортировка по кол-ву ■";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Visible = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.searchTextBox.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.searchTextBox.Location = new System.Drawing.Point(572, 71);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 23);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.Visible = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Chartreuse;
            this.headerPanel.Controls.Add(this.addProductButton);
            this.headerPanel.Controls.Add(this.headerTitleLabel);
            this.headerPanel.Controls.Add(this.logOutButton);
            this.headerPanel.Controls.Add(this.headerLogoPictureBox);
            this.headerPanel.Controls.Add(this.userFullNameLabel);
            this.headerPanel.Controls.Add(this.headerSubtitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(678, 70);
            this.headerPanel.TabIndex = 1;
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.AutoSize = true;
            this.headerTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerTitleLabel.Location = new System.Drawing.Point(77, 17);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(141, 23);
            this.headerTitleLabel.TabIndex = 1;
            this.headerTitleLabel.Text = "ООО \"Обувь\"";
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.logOutButton.Location = new System.Drawing.Point(623, 3);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(49, 23);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Выйти";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // headerLogoPictureBox
            // 
            this.headerLogoPictureBox.Image = global::shoes.Properties.Resources.Icon2;
            this.headerLogoPictureBox.Location = new System.Drawing.Point(1, -1);
            this.headerLogoPictureBox.Name = "headerLogoPictureBox";
            this.headerLogoPictureBox.Size = new System.Drawing.Size(70, 70);
            this.headerLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerLogoPictureBox.TabIndex = 0;
            this.headerLogoPictureBox.TabStop = false;
            // 
            // userFullNameLabel
            // 
            this.userFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userFullNameLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFullNameLabel.Location = new System.Drawing.Point(476, 3);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Size = new System.Drawing.Size(141, 23);
            this.userFullNameLabel.TabIndex = 3;
            this.userFullNameLabel.Text = "ФИО";
            this.userFullNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // headerSubtitleLabel
            // 
            this.headerSubtitleLabel.AutoSize = true;
            this.headerSubtitleLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerSubtitleLabel.Location = new System.Drawing.Point(77, 40);
            this.headerSubtitleLabel.Name = "headerSubtitleLabel";
            this.headerSubtitleLabel.Size = new System.Drawing.Size(52, 16);
            this.headerSubtitleLabel.TabIndex = 2;
            this.headerSubtitleLabel.Text = "Товары";
            // 
            // contentFlowLayoutPanel
            // 
            this.contentFlowLayoutPanel.AutoScroll = true;
            this.contentFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.contentFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentFlowLayoutPanel.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.contentFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.contentFlowLayoutPanel.Name = "contentFlowLayoutPanel";
            this.contentFlowLayoutPanel.Size = new System.Drawing.Size(678, 350);
            this.contentFlowLayoutPanel.TabIndex = 0;
            // 
            // shapkin_DemoShoesDataSet
            // 
            this.shapkin_DemoShoesDataSet.DataSetName = "Shapkin_DemoShoesDataSet";
            this.shapkin_DemoShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyerBindingSource
            // 
            this.supplyerBindingSource.DataMember = "Supplyer";
            this.supplyerBindingSource.DataSource = this.shapkin_DemoShoesDataSet;
            // 
            // supplyerTableAdapter
            // 
            this.supplyerTableAdapter.ClearBeforeFill = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductButton.BackColor = System.Drawing.Color.LightGray;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.addProductButton.Location = new System.Drawing.Point(591, 43);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(81, 22);
            this.addProductButton.TabIndex = 9;
            this.addProductButton.Text = "Доб. товар";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Visible = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.formSplitContainer);
            this.MinimumSize = new System.Drawing.Size(694, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Обувь\" | Товары";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel1.PerformLayout();
            this.formSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_DemoShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.Label headerSubtitleLabel;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.PictureBox headerLogoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel contentFlowLayoutPanel;
        private System.Windows.Forms.Label userFullNameLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox filterComboBox;
        private Shapkin_DemoShoesDataSet shapkin_DemoShoesDataSet;
        private System.Windows.Forms.BindingSource supplyerBindingSource;
        private Shapkin_DemoShoesDataSetTableAdapters.SupplyerTableAdapter supplyerTableAdapter;
        private System.Windows.Forms.Button addProductButton;
    }
}