using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24.age.calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int birthYear, currentYear, age;

            currentYear = DateTime.Now.Year;

            birthYear = Convert.ToInt32(textBox1.Text);

            age = currentYear - birthYear;

            MessageBox.Show("Your Age: " + age.ToString());




        }
    }
}
