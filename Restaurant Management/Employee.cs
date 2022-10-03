using DataAccessLayer.Entity;
using DataAccessLayer.Operation;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnEInfo_Click(object sender, EventArgs e)
        {
            gBoxEInfo.Visible = true;
            gBoxOrderDetails.Visible = false;
            ClassID classid = new ClassID();
            string email=classid.getEmail();
            txtEmail.Text = email;
            EProduct eproduct = new EProduct();
            eproduct.Email = txtEmail.Text;



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            gBoxEInfo.Visible = false;
        }

        private void btnOrderQueue_Click(object sender, EventArgs e)
        {
            gBoxOrderDetails.Visible = true;
            gBoxEInfo.Visible = false;
            OProduct oproduct = new OProduct();
            SqlDataAdapter sql = oproduct.showOrder();
            DataTable datatable = new DataTable();
            sql.Fill(datatable);
            GridViewOrder.DataSource = datatable;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void GridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


            //check first string
            if (!Regex.IsMatch(txtEmail.Text, pattern))
            {
                MessageBox.Show("Enter a valid Email address ");
            }
            else
            {

            }

        }
    }
}
