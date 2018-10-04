using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Read balance
            double balance = double.Parse(txtAmount.Text);

            for (int y = 0; y < 5; y++)
            {
                balance += .05 * balance;
            }

            balance = Math.Round(balance, 2);
            lblTotal.Text = "€ " + balance.ToString("0.00");

        }
    }
}
