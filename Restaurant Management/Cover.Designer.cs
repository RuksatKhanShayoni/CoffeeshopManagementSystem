
namespace Restaurant_Management
{
    partial class Cover
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
            this.lnkOrder = new System.Windows.Forms.LinkLabel();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkDashboard = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkOrder
            // 
            this.lnkOrder.AutoSize = true;
            this.lnkOrder.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOrder.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkOrder.Location = new System.Drawing.Point(260, 530);
            this.lnkOrder.Name = "lnkOrder";
            this.lnkOrder.Size = new System.Drawing.Size(159, 29);
            this.lnkOrder.TabIndex = 4;
            this.lnkOrder.TabStop = true;
            this.lnkOrder.Text = "Place an Order";
            this.lnkOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOrder_LinkClicked);
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkBack.Location = new System.Drawing.Point(12, 18);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(24, 17);
            this.lnkBack.TabIndex = 5;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "<<";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Restaurant_Management.Properties.Resources.Screenshot_2021_12_18_023109;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lnkDashboard
            // 
            this.lnkDashboard.AutoSize = true;
            this.lnkDashboard.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDashboard.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkDashboard.Location = new System.Drawing.Point(494, 530);
            this.lnkDashboard.Name = "lnkDashboard";
            this.lnkDashboard.Size = new System.Drawing.Size(122, 29);
            this.lnkDashboard.TabIndex = 6;
            this.lnkDashboard.TabStop = true;
            this.lnkDashboard.Text = "Dashboard";
            this.lnkDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDashboard_LinkClicked);
            // 
            // Cover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 578);
            this.Controls.Add(this.lnkDashboard);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.lnkOrder);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cover";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cover";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkOrder;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.LinkLabel lnkDashboard;
    }
}