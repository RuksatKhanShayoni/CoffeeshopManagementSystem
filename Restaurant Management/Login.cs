using DataAccessLayer.Entity;
using DataAccessLayer.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Login : Form
    {
        int approve;
        public Login()
        {
            InitializeComponent();
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int flg = 1;
            if(cboxLoginAs.ToString() =="")
            {
                MessageBox.Show("Choose a user");
                flg = 0;

            }
            if(txtID.Text== "")
            {
                MessageBox.Show("You must enter an Id");
                flg = 0;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("You must enter a Password");
                flg = 0;
            }

            if(flg==1)
            {
                EProduct eproduct = new EProduct();
                eproduct.ID = txtID.Text;
                eproduct.Email = txtID.Text;
                eproduct.Pass = txtPass.Text;

                if (cboxLoginAs.SelectedItem.ToString() == "Employee")
                {
                    ClassID classid = new ClassID();
                    classid.setEmail(Convert.ToString(txtID.Text));

                    OProduct oproduct = new OProduct();
                     approve = oproduct.LoginEmployees(eproduct);

                }
                else
                {
                    OProduct oproduct = new OProduct();
                    approve = oproduct.LoginAdmin(eproduct);

                }
            }

           if(approve==1)
            {
                if(cboxLoginAs.SelectedItem.ToString() == "Admin")
                {
                this.Hide();
                new Cover().Show();
                }
                else
                {
                    this.Hide();
                    new Employee().Show();
                }
                
            }
            
            
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new First().Show();
        }

        private void cboxLoginAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
