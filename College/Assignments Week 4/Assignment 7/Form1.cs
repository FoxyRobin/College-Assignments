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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Read side
            string input = txtNr.Text;
            int n = int.Parse(input);

            string horizontal = new string('x', n);
            string vertical = "x" + new string(' ', n - 2) + "x";

            string lblSquare = horizontal + "\n";

            for (int i = 0; i < n - 2; i++)
            {
                lblSquare += vertical + "\n";
            }
            lblSquare += horizontal;
            this.lblSquare.Text = lblSquare;
        }

        private void lblSquare_Click(object sender, EventArgs e)
        {

        }
    }
}
