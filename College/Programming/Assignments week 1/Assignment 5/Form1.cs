using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
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

        private void button1_Click(object sender, EventArgs e)
        {
            //first number
            string input = nr1txt.Text;
            float nr1 = float.Parse(input);

            //second number
            string input2 = nr2txt.Text;
            float nr2 = float.Parse(input2);

            //third number
            string input3 = nr3txt.Text;
            float nr3 = float.Parse(input3);

            //calculating total & average
            float total = nr1 + nr2 + nr3;
            float average = total / 3;

            //show average
            averagelbl.Text = average.ToString();

        }
    }
}
