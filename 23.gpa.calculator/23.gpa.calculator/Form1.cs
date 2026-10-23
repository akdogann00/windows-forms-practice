using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23.gpa.calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double midterm, final, average;

            midterm = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);

            average = (midterm * 0.40) + (final * 0.60);

            textBox3.Text = average.ToString();

            if (average < 50)
            {
                MessageBox.Show("Your Status is Failed");
            }
            else
            {
                MessageBox.Show("Your Status is Succesfull");
            }


        }
    }
}
