
namespace Restaurant_Management
{
    partial class Invoice
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCDetails = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.STlabel = new System.Windows.Forms.Label();
            this.Vlabel = new System.Windows.Forms.Label();
            this.GTlabel = new System.Windows.Forms.Label();
            this.textBoxST = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxGT = new System.Windows.Forms.TextBox();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(17, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(17, 238);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 22);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Indigo;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(296, 341);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 48);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 83);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 23);
            this.txtName.TabIndex = 7;
            // 
            // lblCDetails
            // 
            this.lblCDetails.AutoSize = true;
            this.lblCDetails.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDetails.Location = new System.Drawing.Point(12, 37);
            this.lblCDetails.Name = "lblCDetails";
            this.lblCDetails.Size = new System.Drawing.Size(189, 26);
            this.lblCDetails.TabIndex = 11;
            this.lblCDetails.Text = "Customer Details";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(17, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 22);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblContact.Location = new System.Drawing.Point(13, 198);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(75, 22);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Contact";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 155);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 24);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(100, 196);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(132, 24);
            this.txtContact.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Calculation";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Indigo;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDone.Location = new System.Drawing.Point(296, 63);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(143, 43);
            this.btnDone.TabIndex = 34;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(100, 238);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(132, 22);
            this.txtBoxDate.TabIndex = 35;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(17, 121);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 22);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "Price";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(100, 121);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(132, 22);
            this.txtBoxPrice.TabIndex = 37;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // STlabel
            // 
            this.STlabel.AutoSize = true;
            this.STlabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STlabel.Location = new System.Drawing.Point(560, 146);
            this.STlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.STlabel.Name = "STlabel";
            this.STlabel.Size = new System.Drawing.Size(69, 17);
            this.STlabel.TabIndex = 38;
            this.STlabel.Text = "Sub Total";
            // 
            // Vlabel
            // 
            this.Vlabel.AutoSize = true;
            this.Vlabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vlabel.Location = new System.Drawing.Point(560, 176);
            this.Vlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Vlabel.Name = "Vlabel";
            this.Vlabel.Size = new System.Drawing.Size(29, 17);
            this.Vlabel.TabIndex = 39;
            this.Vlabel.Text = "Vat\r\n";
            // 
            // GTlabel
            // 
            this.GTlabel.AutoSize = true;
            this.GTlabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTlabel.Location = new System.Drawing.Point(560, 220);
            this.GTlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.GTlabel.Name = "GTlabel";
            this.GTlabel.Size = new System.Drawing.Size(85, 17);
            this.GTlabel.TabIndex = 40;
            this.GTlabel.Text = "Grand Total";
            // 
            // textBoxST
            // 
            this.textBoxST.Location = new System.Drawing.Point(654, 146);
            this.textBoxST.Multiline = true;
            this.textBoxST.Name = "textBoxST";
            this.textBoxST.ReadOnly = true;
            this.textBoxST.Size = new System.Drawing.Size(57, 19);
            this.textBoxST.TabIndex = 41;
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(654, 181);
            this.textBoxV.Multiline = true;
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.ReadOnly = true;
            this.textBoxV.Size = new System.Drawing.Size(57, 19);
            this.textBoxV.TabIndex = 42;
            // 
            // textBoxGT
            // 
            this.textBoxGT.Location = new System.Drawing.Point(654, 221);
            this.textBoxGT.Multiline = true;
            this.textBoxGT.Name = "textBoxGT";
            this.textBoxGT.ReadOnly = true;
            this.textBoxGT.Size = new System.Drawing.Size(57, 19);
            this.textBoxGT.TabIndex = 43;
            // 
            // lnkBack
            // 
            this.lnkBack.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkBack.AutoSize = true;
            this.lnkBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkBack.LinkColor = System.Drawing.Color.Black;
            this.lnkBack.Location = new System.Drawing.Point(18, 9);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(24, 17);
            this.lnkBack.TabIndex = 44;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "<<";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(837, 441);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.textBoxGT);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxST);
            this.Controls.Add(this.GTlabel);
            this.Controls.Add(this.Vlabel);
            this.Controls.Add(this.STlabel);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCDetails);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Name = "Invoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label STlabel;
        private System.Windows.Forms.Label Vlabel;
        private System.Windows.Forms.Label GTlabel;
        private System.Windows.Forms.TextBox textBoxST;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxGT;
        private System.Windows.Forms.LinkLabel lnkBack;
    }
}