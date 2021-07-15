using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //input
            int base_input = int.Parse(textBox1.Text);
            int height_input = int.Parse(textBox2.Text);

            //calculate
            double area = 0.5 * base_input * height_input;

            //output
            textBox3.Text = area + "";
           

        }

        
    }
}
