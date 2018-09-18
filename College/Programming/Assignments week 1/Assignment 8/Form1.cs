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

        private void button1_Click(object sender, EventArgs e)
        {
            //Number of shirts
            string input = shirttxt.Text;
            float shirts = float.Parse(input);

            //Number of jeans
            string input2 = jeanstxt.Text;
            float jeans = float.Parse(input2);

            //Calculate price shirts and jeans
            float shirtsprice = shirts * 30.00f;
            float jeansprice = jeans * 100.00f;

            //Total price excl VAT
            float totalexcl = shirtsprice + jeansprice;

            //VAT
            float VAT = totalexcl / 100 * 21;

            //Total price incl VAT
            float totalincl = totalexcl + VAT;

            //Display
            datelbl.Text = DateTime.Now.ToString();
            pricelbl.Text = "€" + totalexcl.ToString();
            VATlbl.Text = "€" + VAT.ToString();
            totallbl.Text = "€" + totalincl.ToString();
        }
    }
}
