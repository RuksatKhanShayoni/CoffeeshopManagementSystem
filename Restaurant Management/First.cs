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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
