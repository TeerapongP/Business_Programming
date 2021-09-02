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

            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult ok_or_cancel = openFileDialog.ShowDialog();
            if (ok_or_cancel == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBox2.Text = filePath;

                //สร้างออบเจครูปภาพจากตำแหน่งไฟล์
                Image img = Image.FromFile(textBox2.Text);
                pictureBox1.Image = img; //เปลี่ยนรูปใน pictureBox1


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string  name = textBox1.Text;

            //datetimepicker1.value <=> วันที่เลือกจาก datetimepicker1
            DateTime dob = dateTimePicker1.Value.Date;
            DateTime today = DateTime.Now;
            TimeSpan time_diff = (today - dob);

            //ผิดในกรณี leap year ปีที่มี 29 วัน
            int age = (int)(time_diff.TotalDays / 365); 

            bool driving = checkBox1.Checked;

            int row_id = dataGridView1.Rows.Add();
            dataGridView1.Rows[row_id].Cells[0].Value = name;
            dataGridView1.Rows[row_id].Cells[1].Value = dob.Date.ToShortDateString();//ตัดส่วนเวลาทิ้ง
            dataGridView1.Rows[row_id].Cells[2].Value = age;
            dataGridView1.Rows[row_id].Cells[3].Value = driving;
            //dataGridView1.Rows[row_id].Cells[4].Value = Image.FromFile(textBox2.Text);
            dataGridView1.Rows[row_id].Cells[4].Value = pictureBox1.Image;
        }
    }
}
