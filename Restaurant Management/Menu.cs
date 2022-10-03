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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            EProduct eproduct = new EProduct();
            int price = 0;
            if (cboxLatte.Text != "")
            {
                price += Convert.ToInt32(cboxLatte.Text) * 140;
                eproduct.Latte = Convert.ToInt32(cboxLatte.Text);

            }


            if (cboxMocha.Text != "")
            {
                price += Convert.ToInt32(cboxMocha.Text) * 175;
                eproduct.Mocha = Convert.ToInt32(cboxMocha.Text);

            }

            if (cboxFWhite.Text != "")
            {
                price += Convert.ToInt32(cboxFWhite.Text) * 120;
                eproduct.Flatwhite = Convert.ToInt32(cboxFWhite.Text);
            }

            if (cboxEspresso.Text != "")
            {
                price += Convert.ToInt32(cboxEspresso.Text) * 150;
                eproduct.Espresso = Convert.ToInt32(cboxEspresso.Text);
            }

            if (cboxAmericano.Text != "")
            {
                price += Convert.ToInt32(cboxAmericano.Text) * 150;
                eproduct.Americano = Convert.ToInt32(cboxAmericano.Text);
            }

            if (cboxCappuccino.Text != "")
            {
                price += Convert.ToInt32(cboxCappuccino.Text) * 150;
                eproduct.Cappuccino = Convert.ToInt32(cboxCappuccino.Text);
            }

            MessageBox.Show("Total ammount to pay is " + price);
            OProduct oproduct = new OProduct();
            oproduct.OrderQ(eproduct);



            MessageBox.Show("Your Order has been confirmed");
           



            this.Hide();
            new Invoice().Show();
        }

        private void pctrLogo_Click(object sender, EventArgs e)
        {

        }

        private void lnkbackC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Cover().Show();
        }
    }
}
