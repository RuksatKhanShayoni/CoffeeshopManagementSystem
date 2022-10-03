
namespace Restaurant_Management
{
    partial class Employee
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
            this.btnEInfo = new System.Windows.Forms.Button();
            this.btnOrderQueue = new System.Windows.Forms.Button();
            this.gBoxEInfo = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.GridViewOrder = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gBoxEInfo.SuspendLayout();
            this.gBoxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEInfo
            // 
            this.btnEInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEInfo.Location = new System.Drawing.Point(116, 62);
            this.btnEInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEInfo.Name = "btnEInfo";
            this.btnEInfo.Size = new System.Drawing.Size(184, 55);
            this.btnEInfo.TabIndex = 0;
            this.btnEInfo.Text = "Employee Information";
            this.btnEInfo.UseVisualStyleBackColor = false;
            this.btnEInfo.Click += new System.EventHandler(this.btnEInfo_Click);
            // 
            // btnOrderQueue
            // 
            this.btnOrderQueue.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrderQueue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderQueue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderQueue.Location = new System.Drawing.Point(379, 62);
            this.btnOrderQueue.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderQueue.Name = "btnOrderQueue";
            this.btnOrderQueue.Size = new System.Drawing.Size(184, 55);
            this.btnOrderQueue.TabIndex = 1;
            this.btnOrderQueue.Text = "Order Queue";
            this.btnOrderQueue.UseVisualStyleBackColor = false;
            this.btnOrderQueue.Click += new System.EventHandler(this.btnOrderQueue_Click);
            // 
            // gBoxEInfo
            // 
            this.gBoxEInfo.Controls.Add(this.btnClose);
            this.gBoxEInfo.Controls.Add(this.btnUpdate);
            this.gBoxEInfo.Controls.Add(this.txtName);
            this.gBoxEInfo.Controls.Add(this.txtEmail);
            this.gBoxEInfo.Controls.Add(this.lblPassword);
            this.gBoxEInfo.Controls.Add(this.lblEmail);
            this.gBoxEInfo.Location = new System.Drawing.Point(285, 171);
            this.gBoxEInfo.Name = "gBoxEInfo";
            this.gBoxEInfo.Size = new System.Drawing.Size(332, 266);
            this.gBoxEInfo.TabIndex = 2;
            this.gBoxEInfo.TabStop = false;
            this.gBoxEInfo.Text = "Employee Info";
            this.gBoxEInfo.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(223, 188);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 24);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(103, 188);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 24);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 112);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 19);
            this.txtName.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 46);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(126, 19);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(17, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Set Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(18, 46);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // gBoxOrderDetails
            // 
            this.gBoxOrderDetails.Controls.Add(this.GridViewOrder);
            this.gBoxOrderDetails.Location = new System.Drawing.Point(190, 293);
            this.gBoxOrderDetails.Name = "gBoxOrderDetails";
            this.gBoxOrderDetails.Size = new System.Drawing.Size(504, 278);
            this.gBoxOrderDetails.TabIndex = 3;
            this.gBoxOrderDetails.TabStop = false;
            this.gBoxOrderDetails.Text = "Order Details";
            this.gBoxOrderDetails.Visible = false;
            // 
            // GridViewOrder
            // 
            this.GridViewOrder.BackgroundColor = System.Drawing.Color.Honeydew;
            this.GridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOrder.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridViewOrder.Location = new System.Drawing.Point(38, 40);
            this.GridViewOrder.Name = "GridViewOrder";
            this.GridViewOrder.RowHeadersWidth = 51;
            this.GridViewOrder.RowTemplate.Height = 24;
            this.GridViewOrder.Size = new System.Drawing.Size(383, 201);
            this.GridViewOrder.TabIndex = 0;
            this.GridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewOrder_CellContentClick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(627, 62);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(184, 55);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<<";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(884, 618);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gBoxOrderDetails);
            this.Controls.Add(this.gBoxEInfo);
            this.Controls.Add(this.btnOrderQueue);
            this.Controls.Add(this.btnEInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.ShowIcon = false;
            this.Text = "Employee Dashboard";
            this.gBoxEInfo.ResumeLayout(false);
            this.gBoxEInfo.PerformLayout();
            this.gBoxOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEInfo;
        private System.Windows.Forms.Button btnOrderQueue;
        private System.Windows.Forms.GroupBox gBoxEInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gBoxOrderDetails;
        private System.Windows.Forms.DataGridView GridViewOrder;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}