using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            DialogResult ok_or_calcel = openFileDialog.ShowDialog();

           if(ok_or_calcel == DialogResult.OK)
            {
                string file_path = openFileDialog.FileName;
                textBox1.Text = file_path;

                //สร้างออปเจครูปภาพจากตำเเหน่ง
                Image img = Image.FromFile(textBox1.Text);
                pictureBox1.Image = img;//เปลี่ยนรูปใน Picturebox

            }
        }
    }
}
