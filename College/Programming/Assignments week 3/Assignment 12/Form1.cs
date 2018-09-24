using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            //Basic price ticket
            int bprice = 12;

            //Read age
            string input = txt_age.Text;
            int age = int.Parse(input);

            //Price tickets
            int free_ticket = 0;
            int half_ticket = bprice / 2;
            
            //Display price ticket
            if (age < 5)
            {
                lbl_price.Text = "€ " + free_ticket.ToString("0.00");
            }
            else if (age >= 5 && age <= 12)
            {
                lbl_price.Text = "€ " + half_ticket.ToString("0.00");
            }
            else if (age >= 13 && age <= 54)
            {
                lbl_price.Text = "€ " + bprice.ToString("0.00");
            }
            else if (age >= 55)
            {
                lbl_price.Text = "€ " + free_ticket.ToString("0.00");
            }

        }
    }
}
