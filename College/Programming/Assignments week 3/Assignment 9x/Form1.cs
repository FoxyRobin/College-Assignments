using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9x
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Membership fees
            int fee_football = 175;
            int fee_handball = 225;

            //Read age
            string input = txt_age.Text;
            int age = int.Parse(input);

            //Read membership duration
            string input2 = txt_ms_dur.Text;
            int ms_dur = int.Parse(input);

            //Calculating fees incl discounts
            float fball_fee_over40 = fee_football - 25;
            float fball_fee_10y = fee_football - 20;
            float fball_fee_both = fee_football - 25 - 20;

            //Calculating fees incl discounts
            float hball_fee_over40 = fee_handball - 25;
            float hball_fee_10y = fee_handball - 20;
            float hball_fee_both = fee_handball - 25 - 20;

            //Fee to be paid football
            if (radioBtn_fball.Checked == true && age >= 40)
            {
                lbl_fee.Text = "€ " + fball_fee_over40.ToString("0.00");
            }
            else if (radioBtn_fball.Checked == true && ms_dur >= 10)
            {
                lbl_fee.Text = "€ " + fball_fee_10y.ToString("0.00");
            }
            else if (radioBtn_fball.Checked == true && ms_dur >= 10 && age >= 40)
            {
                lbl_fee.Text = "€ " + fball_fee_both.ToString("0.00");
            }
            else if (radioBtn_fball.Checked == true)
            {
                lbl_fee.Text = "€ " + fee_football.ToString("0.00");
            }
            //Fee to be paid handball
            else if (radioBtn_hball.Checked == true && age >= 40)
            {
                lbl_fee.Text = "€ " + hball_fee_over40.ToString("0.00");
            }
            else if (radioBtn_hball.Checked == true && ms_dur >= 10)
            {
                lbl_fee.Text = "€ " + hball_fee_10y.ToString("0.00");
            }
            else if (radioBtn_fball.Checked == true && ms_dur >= 10 && age >= 40)
            {
                lbl_fee.Text = "€ " + hball_fee_both.ToString("0.00");
            }
            else if (radioBtn_fball.Checked == true)
            {
                lbl_fee.Text = "€ " + fee_handball.ToString("0.00");
            }
        }
    }
}
