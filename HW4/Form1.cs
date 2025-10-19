using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form1 : Form
    {
        string imagePath = "";
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                imagePath = open.FileName; 
            }

        }

    private void button2_Click(object sender, EventArgs e)
        {
            string sex = rbnMale.Checked ? "Male" : (rbnFemale.Checked ? "Female" : "");

            Form2 form2 = new Form2(
                txtMobile.Text,
                txtFirstname.Text,
                txtLastname.Text,
                sex,
                cbxStatus.Text,
                dtrBirthday.Value.ToShortDateString(),
                txtLocation.Text,
                pictureBox1.Image
            );

            form2.Show();
            this.Hide();
        }


    }
}
    
    

