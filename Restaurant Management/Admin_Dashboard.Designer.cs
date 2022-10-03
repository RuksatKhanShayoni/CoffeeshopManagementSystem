
namespace Restaurant_Management
{
    partial class Dashboard
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
            this.btnMEmployyees = new System.Windows.Forms.Button();
            this.btnBHistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.GridViewRemove = new System.Windows.Forms.DataGridView();
            this.GridViewBill = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonremove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxRemove = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBill)).BeginInit();
            this.gBoxRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMEmployyees
            // 
            this.btnMEmployyees.BackColor = System.Drawing.Color.Peru;
            this.btnMEmployyees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMEmployyees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMEmployyees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMEmployyees.Location = new System.Drawing.Point(101, 40);
            this.btnMEmployyees.Name = "btnMEmployyees";
            this.btnMEmployyees.Size = new System.Drawing.Size(141, 55);
            this.btnMEmployyees.TabIndex = 1;
            this.btnMEmployyees.Text = "Manage Employees";
            this.btnMEmployyees.UseVisualStyleBackColor = false;
            this.btnMEmployyees.Click += new System.EventHandler(this.btnMEmployyees_Click);
            // 
            // btnBHistory
            // 
            this.btnBHistory.BackColor = System.Drawing.Color.Peru;
            this.btnBHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBHistory.Location = new System.Drawing.Point(310, 40);
            this.btnBHistory.Name = "btnBHistory";
            this.btnBHistory.Size = new System.Drawing.Size(151, 55);
            this.btnBHistory.TabIndex = 2;
            this.btnBHistory.Text = "Billing History";
            this.btnBHistory.UseVisualStyleBackColor = false;
            this.btnBHistory.Click += new System.EventHandler(this.btnBHistory_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Peru;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(552, 40);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 55);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(310, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose an option";
            this.groupBox1.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Peru;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(235, 32);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 55);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove Employees";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Peru;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(35, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Employees";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkBack.LinkColor = System.Drawing.Color.Peru;
            this.lnkBack.Location = new System.Drawing.Point(34, 20);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(24, 17);
            this.lnkBack.TabIndex = 5;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "<<";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // GridViewRemove
            // 
            this.GridViewRemove.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.GridViewRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRemove.Location = new System.Drawing.Point(37, 286);
            this.GridViewRemove.Name = "GridViewRemove";
            this.GridViewRemove.RowHeadersWidth = 51;
            this.GridViewRemove.RowTemplate.Height = 24;
            this.GridViewRemove.Size = new System.Drawing.Size(420, 226);
            this.GridViewRemove.TabIndex = 7;
            this.GridViewRemove.Visible = false;
            // 
            // GridViewBill
            // 
            this.GridViewBill.BackgroundColor = System.Drawing.Color.Honeydew;
            this.GridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBill.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridViewBill.Location = new System.Drawing.Point(307, 312);
            this.GridViewBill.Margin = new System.Windows.Forms.Padding(1);
            this.GridViewBill.Name = "GridViewBill";
            this.GridViewBill.RowHeadersWidth = 51;
            this.GridViewBill.RowTemplate.Height = 24;
            this.GridViewBill.Size = new System.Drawing.Size(430, 212);
            this.GridViewBill.TabIndex = 10;
            this.GridViewBill.Visible = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(135, 32);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(113, 22);
            this.textBoxID.TabIndex = 12;
            // 
            // buttonremove
            // 
            this.buttonremove.BackColor = System.Drawing.Color.Peru;
            this.buttonremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonremove.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonremove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonremove.Location = new System.Drawing.Point(192, 89);
            this.buttonremove.Margin = new System.Windows.Forms.Padding(1);
            this.buttonremove.Name = "buttonremove";
            this.buttonremove.Size = new System.Drawing.Size(88, 24);
            this.buttonremove.TabIndex = 13;
            this.buttonremove.Text = "Remove";
            this.buttonremove.UseVisualStyleBackColor = false;
            this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter ID";
            // 
            // gBoxRemove
            // 
            this.gBoxRemove.Controls.Add(this.buttonremove);
            this.gBoxRemove.Controls.Add(this.label1);
            this.gBoxRemove.Controls.Add(this.textBoxID);
            this.gBoxRemove.Location = new System.Drawing.Point(386, 312);
            this.gBoxRemove.Name = "gBoxRemove";
            this.gBoxRemove.Size = new System.Drawing.Size(319, 142);
            this.gBoxRemove.TabIndex = 14;
            this.gBoxRemove.TabStop = false;
            this.gBoxRemove.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1075, 524);
            this.Controls.Add(this.gBoxRemove);
            this.Controls.Add(this.GridViewBill);
            this.Controls.Add(this.GridViewRemove);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBHistory);
            this.Controls.Add(this.btnMEmployyees);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBill)).EndInit();
            this.gBoxRemove.ResumeLayout(false);
            this.gBoxRemove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMEmployyees;
        private System.Windows.Forms.Button btnBHistory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.DataGridView GridViewRemove;
        private System.Windows.Forms.DataGridView GridViewBill;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonremove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxRemove;
    }
}