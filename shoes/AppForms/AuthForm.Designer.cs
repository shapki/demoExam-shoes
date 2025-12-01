
namespace shoes.AppForms
{
    partial class AuthForm
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.headerSubtitleLabel = new System.Windows.Forms.Label();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.headerLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.guestLogInButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapkin_DemoShoesDataSet = new shoes.Shapkin_DemoShoesDataSet();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTableAdapter = new shoes.Shapkin_DemoShoesDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new shoes.Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_DemoShoesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            loginLabel.Location = new System.Drawing.Point(3, 10);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(48, 16);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            passwordLabel.Location = new System.Drawing.Point(3, 36);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(53, 16);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль:";
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
            this.formSplitContainer.Panel2.Controls.Add(this.guestLogInButton);
            this.formSplitContainer.Panel2.Controls.Add(this.logInButton);
            this.formSplitContainer.Panel2.Controls.Add(loginLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.loginTextBox);
            this.formSplitContainer.Panel2.Controls.Add(passwordLabel);
            this.formSplitContainer.Panel2.Controls.Add(this.passwordTextBox);
            this.formSplitContainer.Size = new System.Drawing.Size(376, 150);
            this.formSplitContainer.SplitterDistance = 80;
            this.formSplitContainer.TabIndex = 3;
            // 
            // headerSubtitleLabel
            // 
            this.headerSubtitleLabel.AutoSize = true;
            this.headerSubtitleLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerSubtitleLabel.Location = new System.Drawing.Point(81, 46);
            this.headerSubtitleLabel.Name = "headerSubtitleLabel";
            this.headerSubtitleLabel.Size = new System.Drawing.Size(82, 16);
            this.headerSubtitleLabel.TabIndex = 2;
            this.headerSubtitleLabel.Text = "Авторизация";
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
            // guestLogInButton
            // 
            this.guestLogInButton.Location = new System.Drawing.Point(272, 33);
            this.guestLogInButton.Name = "guestLogInButton";
            this.guestLogInButton.Size = new System.Drawing.Size(92, 24);
            this.guestLogInButton.TabIndex = 5;
            this.guestLogInButton.Text = "Войти гостем";
            this.guestLogInButton.UseVisualStyleBackColor = true;
            this.guestLogInButton.Click += new System.EventHandler(this.guestLogInButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(272, 5);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(92, 24);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Войти";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(66, 8);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.shapkin_DemoShoesDataSet;
            // 
            // shapkin_DemoShoesDataSet
            // 
            this.shapkin_DemoShoesDataSet.DataSetName = "Shapkin_DemoShoesDataSet";
            this.shapkin_DemoShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(66, 34);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SupplyerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shoes.Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 150);
            this.Controls.Add(this.formSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 189);
            this.MinimumSize = new System.Drawing.Size(392, 189);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Обувь\" | Авторизация";
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel1.PerformLayout();
            this.formSplitContainer.Panel2.ResumeLayout(false);
            this.formSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_DemoShoesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.Label headerSubtitleLabel;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.PictureBox headerLogoPictureBox;
        private Shapkin_DemoShoesDataSet shapkin_DemoShoesDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Shapkin_DemoShoesDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private Shapkin_DemoShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button guestLogInButton;
    }
}