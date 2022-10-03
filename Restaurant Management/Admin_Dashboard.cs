using DataAccessLayer.Entity;
using DataAccessLayer.Operation;
using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnMEmployyees_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            GridViewBill.Visible = false;

        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Cover().Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormSignUp().Show();
          
            GridViewRemove.Visible = false;

           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            gBoxRemove.Visible = true;
            GridViewRemove.Visible = true;
            OProduct oproduct = new OProduct();
            SqlDataAdapter sql = oproduct.showStaff();
            DataTable datatable = new DataTable();
            sql.Fill(datatable);
            GridViewRemove.DataSource = datatable;



        }

       

        private void btnBHistory_Click(object sender, EventArgs e)
        {
            GridViewBill.Visible = true;
            GridViewRemove.Visible = false;
           
            groupBox1.Visible = false;
            OProduct oproduct = new OProduct();
            SqlDataAdapter sql=oproduct.show();    
            DataTable datatable = new DataTable();
            sql.Fill(datatable);
            GridViewBill.DataSource = datatable;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void GridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            EProduct eproduct = new EProduct();
            eproduct.SID = Convert.ToInt32(textBoxID.Text);
            OProduct oproduct = new OProduct();
            oproduct.deleteStaff(eproduct);
            SqlDataAdapter sql = oproduct.showStaff();
            DataTable datatable = new DataTable();
            sql.Fill(datatable);
            GridViewRemove.DataSource = datatable;



        }
    }
}
