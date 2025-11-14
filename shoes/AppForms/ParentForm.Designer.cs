
namespace shoes.AppForms
{
    partial class ParentForm
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
            this.headerSubtitleLabel = new System.Windows.Forms.Label();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.headerLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.contentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formSplitContainer
            // 
            this.formSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.formSplitContainer.Panel2.Controls.Add(this.contentFlowLayoutPanel);
            this.formSplitContainer.Size = new System.Drawing.Size(678, 450);
            this.formSplitContainer.SplitterDistance = 80;
            this.formSplitContainer.TabIndex = 3;
            // 
            // headerSubtitleLabel
            // 
            this.headerSubtitleLabel.AutoSize = true;
            this.headerSubtitleLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerSubtitleLabel.Location = new System.Drawing.Point(81, 46);
            this.headerSubtitleLabel.Name = "headerSubtitleLabel";
            this.headerSubtitleLabel.Size = new System.Drawing.Size(51, 16);
            this.headerSubtitleLabel.TabIndex = 2;
            this.headerSubtitleLabel.Text = "Товары";
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
            // contentFlowLayoutPanel
            // 
            this.contentFlowLayoutPanel.AutoScroll = true;
            this.contentFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.contentFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentFlowLayoutPanel.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.contentFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.contentFlowLayoutPanel.Name = "contentFlowLayoutPanel";
            this.contentFlowLayoutPanel.Size = new System.Drawing.Size(678, 366);
            this.contentFlowLayoutPanel.TabIndex = 0;
            // 
            // PparentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.formSplitContainer);
            this.Name = "PparentForm";
            this.Text = "ООО \"Обувь\"";
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel1.PerformLayout();
            this.formSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.Label headerSubtitleLabel;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.PictureBox headerLogoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel contentFlowLayoutPanel;
    }
}