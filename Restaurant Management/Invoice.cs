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
    
    public partial class Invoice : Form
    {
        int ammount;
        public Invoice()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(txtName.Text =="")
            {
                MessageBox.Show("You must enter your name");
            }
            else if((txtEmail.Text == "" || txtEmail.Text == "$" || txtEmail.Text == "#" || txtEmail.Text == "&" || txtEmail.Text == "(" || txtEmail.Text == ")"))
            {
                MessageBox.Show("Invalid ! Enter again");
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("You must enter your Contact info");
            }
            else
            {
                MessageBox.Show("Your invoice has been printed");
                this.Hide();
                new Cover().Show();
            }
           
        }

      
        private void btnDone_Click(object sender, EventArgs e)
        {
            EProduct eproduct = new EProduct();
            eproduct.Name = txtName.Text;
            eproduct.Email = txtEmail.Text;
            eproduct.Contact_No = txtContact.Text;
            eproduct.Date = txtBoxDate.Text;
           
            eproduct.Price = Convert.ToInt32(txtBoxPrice.Text);

           
            OProduct oproduct = new OProduct();
            oproduct.InsertOrder(eproduct);

            double subtotal = Convert.ToInt32(txtBoxPrice.Text);
            double vat = 0.15;
            double GT =subtotal+(subtotal * vat);
            textBoxST.Text =Convert.ToString(subtotal);
            textBoxV.Text = Convert.ToString(vat);
            textBoxGT.Text =Convert.ToString(GT);



          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


            //check first string
            if (! Regex.IsMatch(txtEmail.Text, pattern))
            {
                MessageBox.Show("Enter a valid Email address ");
            }
            else
            {
               
            }

        }
    }
}
