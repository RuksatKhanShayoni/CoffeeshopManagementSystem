

using DataAccessLayer.Entity;
using DataAccessLayer.Operation;
using System;
using System.Text.RegularExpressions;
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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == textBoxCPass.Text)
            {
                EProduct eproduct = new EProduct();
                eproduct.Name = textBoxName.Text;
                eproduct.Email = textBoxEmail.Text;
                eproduct.Pass = textBoxPass.Text;
                OProduct oproduct = new OProduct();
                int number = oproduct.Insert(eproduct);

                string pattern = null;
                pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


                //check first string
                if (!Regex.IsMatch(textBoxEmail.Text, pattern))
                {
                    MessageBox.Show("Enter a valid Email address ");
                }
                else
                {

                }

                if (number > 0)
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("Not Successful");
                }

                // MessageBox.Show("Your password matched!");
                //listBox1.Items.Add(textBoxName.Text);
                //listBox1.Items.Add(textBoxEmail.Text);
                //listBox1.Items.Add(textBoxPass.Text);
                //listBox1.Items.Add(textBoxCPass.Text);
                //listBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Your password didn't match!");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
     

            new Login().Show();
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
