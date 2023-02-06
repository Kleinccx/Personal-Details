using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            string gender = "";
            string hobbies = "";
            if (rMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (chkMusic.Checked)
            {
                hobbies = hobbies + "Music ";
            }
            if (chkMovies.Checked)
            {
                hobbies = hobbies + "Movies ";
            }
            if (chkPiano.Checked)
            {
                hobbies = hobbies + "Piano ";
            }
            if (chkGuitar.Checked)
            {
                hobbies = hobbies + "Guitar ";
            }
            if (chkCrafting.Checked)
            {
                hobbies = hobbies + "Crafting ";
            }
            if (chkbBall.Checked)
            {
                hobbies = hobbies + "BasketBall ";
            }

            int myAge = DateTime.Now.Year - bDate.Value.Year;
            if (bDate.Value.AddYears(myAge) > DateTime.Now) myAge--;

           
         


            string details = "Name: " + txtName.Text +
                             "\nBirthDate: " + bDate.Value +
                             "\nAge: " + myAge +
                             "\nGender: " + gender +
                             "\nHobbies: " + hobbies;

            MessageBox.Show(details,"Personal Info Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|.jpg; *.png; *.jpeg; *.gif *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = new Bitmap(open.FileName);
            }

        }

        private void picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|.jpg; *.png; *.jpeg; *.gif *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = new Bitmap(open.FileName);
            }

        }
    }
}
