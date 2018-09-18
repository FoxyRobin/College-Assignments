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

        private void button1_Click(object sender, EventArgs e)
        {
            string input = timetxt.Text;
            int seconds = int.Parse(input);

            TimeSpan timespan = TimeSpan.FromSeconds(seconds);
            int hour = timespan.Hours;
            int min = timespan.Minutes;
            int sec = timespan.Seconds;

            hourlbl.Text = hour.ToString();
            minlbl.Text = min.ToString();
            seclbl.Text = sec.ToString();
        }

        private void minlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
