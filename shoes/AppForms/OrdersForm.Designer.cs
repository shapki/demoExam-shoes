namespace shoes.AppForms
{
    partial class OrdersForm
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
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.headerLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.headerSubtitleLabel = new System.Windows.Forms.Label();
            this.contentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).BeginInit();
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
            this.formSplitContainer.Panel1.Controls.Add(this.addOrderButton);
            this.formSplitContainer.Panel1.Controls.Add(this.headerPanel);
            // 
            // formSplitContainer.Panel2
            // 
            this.formSplitContainer.Panel2.Controls.Add(this.contentFlowLayoutPanel);
            this.formSplitContainer.Size = new System.Drawing.Size(678, 450);
            this.formSplitContainer.SplitterDistance = 96;
            this.formSplitContainer.TabIndex = 3;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addOrderButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.addOrderButton.Location = new System.Drawing.Point(591, 72);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(81, 22);
            this.addOrderButton.TabIndex = 9;
            this.addOrderButton.Text = "Доб. заказ";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Visible = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Chartreuse;
            this.headerPanel.Controls.Add(this.headerTitleLabel);
            this.headerPanel.Controls.Add(this.headerLogoPictureBox);
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
            // headerSubtitleLabel
            // 
            this.headerSubtitleLabel.AutoSize = true;
            this.headerSubtitleLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerSubtitleLabel.Location = new System.Drawing.Point(77, 40);
            this.headerSubtitleLabel.Name = "headerSubtitleLabel";
            this.headerSubtitleLabel.Size = new System.Drawing.Size(43, 16);
            this.headerSubtitleLabel.TabIndex = 2;
            this.headerSubtitleLabel.Text = "Зказы";
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
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.formSplitContainer);
            this.MinimumSize = new System.Drawing.Size(694, 489);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Обувь\" | Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.PictureBox headerLogoPictureBox;
        private System.Windows.Forms.Label headerSubtitleLabel;
        private System.Windows.Forms.FlowLayoutPanel contentFlowLayoutPanel;
    }
}