using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.form.resizer.project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 700;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 300;
            this.Height = 200;
        }
    }
}
