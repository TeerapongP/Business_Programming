using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double validate_number(string input, string error_message)
        {
            double number = 0;
            try
            {
                number = double.Parse(input);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(error_message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknow Error : โปรแกรมทำงานผิดปกติกรุณาแจ้ง admin");
            }

            return number;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Input
            double BMI = 0;
            double weight = validate_number(textBox1.Text, "น้ำหนักที่กรอกไม่เป็นตัวเลข");
            double height = validate_number(textBox2.Text, "น้ำหนักที่กรอกไม่เป็นตัวเลข");

            //Process
            BMI = weight / (height * height);
            //Output
            
            string obesity_level = " ";

            if (radioButton1.Checked) obesity_level = BMI_Cal_Asia(BMI) + "";
            {
                //Asia
            }

            if (radioButton2.Checked) obesity_level = BMI_Cal_Western(BMI) + "";
            {
                //Westent
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        double BMI_Cal_Western(double BMI)
        {
            string obesity_level = "";
            if (BMI >= 30) obesity_level = "Obes";
            if (BMI >= 25 && BMI <= 30) obesity_level = "Overweight";
            if (BMI >= 18.5 && BMI <= 25) obesity_level = "Normal";
            else obesity_level = "Underweight";
            textBox3.Text = string.Format("{0:N2}", BMI);

            textBox4.Text = obesity_level;
            return BMI;
        }

        double BMI_Cal_Asia(double BMI)
        {
            string obesity_level = "";

            if (BMI >= 30) obesity_level = "Obes";
            if (BMI >= 25 && BMI <= 29.9) obesity_level = "Overweight";
            if (BMI >= 18.5 && BMI <= 24.9) obesity_level = "Normal weight";
            else obesity_level = "Underweight";
            textBox3.Text = string.Format("{0:N2}", BMI);
            textBox4.Text = obesity_level;
            return BMI;
        }

    }
}
