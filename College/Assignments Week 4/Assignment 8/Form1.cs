using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            string input = txtNr.Text;
            int n = int.Parse(input);

            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            int sum2 = n * (n + 1) / 2;

            //Display sums
            lblSum1.Text = sum.ToString("0");
            lblSum2.Text = sum2.ToString("0");

            //

            if (sum == sum2)
            {
                lblFinal.Text = "The sum and formula are equal.";
            }

            else
            {
                lblFinal.Text = "The sum and formula are not equal.";

            }


        }
    }
}
