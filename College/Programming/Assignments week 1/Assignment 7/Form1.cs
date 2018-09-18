using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Start km
            string input = startkmtxt.Text;
            float startkm = float.Parse(input);

            //end km
            string input2 = endkmtxt.Text;
            float endkm = float.Parse(input2);

            //price per km
            string input3 = pricekmtxt.Text;
            float pricekm = float.Parse(input3);

            //calculating
            float totalkm = endkm - startkm;
            float priceexcl = pricekm * totalkm;
            float VAT = priceexcl / 100 * 21;
            float priceincl = VAT + priceexcl;

            //display results
            priceexlbl.Text = priceexcl.ToString();
            VATlbl.Text = VAT.ToString();
            priceinlbl.Text = priceincl.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void erasebtn_Click(object sender, EventArgs e)
        {
            startkmtxt.Text = "";
            endkmtxt.Text = "";
            pricekmtxt.Text = "";

        }
    }
}
