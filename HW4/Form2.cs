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
    public partial class Form2 : Form
    {
        public Form2(string Mobile, 
            string Firstname, 
            string Lastname, 
            string sex, 
            string Status, 
            string Birthday, 
            string Location,
              Image PictureImage)
        {

            InitializeComponent();


            txtMobileDisplay.Text = Mobile;
            txtFirstnameDisplay.Text = Firstname;
            txtLastnameDisplay.Text = Lastname;
            txtLocationDisplay.Text = Location;

            if (sex == "Male")
                rbnMaleDisplay.Checked = true;
            else if (sex == "Female")
                rbnFemaleDisplay.Checked = true;

            cbxStatusDisplay.Text = Status;
            dtrBirthdayDisplay.Text = Birthday;

            
            //if (!string.IsNullOrEmpty(PicturePath))
            //{
              //  try
                {
              //      picDisplay.Image = Image.FromFile(PicturePath);
             //   }
             //   catch
              //  {
                    MessageBox.Show("Unable to load the selected image.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
               /// }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
