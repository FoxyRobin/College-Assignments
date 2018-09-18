using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double VAT_RATE = 0.21;

        private void button1_Click(object sender, EventArgs e)
        {
            string input = priceask.Text;
            double price = double.Parse(input);

            double VAT = price * VAT_RATE;
            double total = price + VAT;

            pricelbl.Text = price.ToString();
            VATlbl.Text = VAT.ToString();
            totallbl.Text = total.ToString();
        }
    }
}
