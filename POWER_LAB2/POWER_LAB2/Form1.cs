using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POWER_LAB2
    //Lab 2 Was designed by Tony Power and fully compiled on 06/10/22, This lab is 2 small programs in one, one is a basic Multiplier calculator and the other is some info on my favourite video game.
{
    public partial class Lab2_Power : Form
    {
        public Lab2_Power()
        {
            InitializeComponent();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //Show Picture Box
            picDestiny.Show();
            infBox.Hide();
           
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //Show Data Box
            infBox.Show();
            picDestiny.Hide();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes Application
            this.Close();  
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //Hide Picture Box and Info Box
            picDestiny.Hide();
            infBox.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset Number and Answer Forms
            txtBox1.ResetText();
            txtBox2.ResetText();
            answerBox.ResetText();

        }

        private void infBox_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Take Text From Box 1 and Box 2 And Display Multiplication in answer box
            int txt1 = Convert.ToDouble(txtBox1.Text);
            int txt2 = Convert.ToDouble(txtBox2.Text);

            int sum = txt1 * txt2;

            answerBox.Text = sum.ToString();
        }

        private void picDestiny_Click(object sender, EventArgs e)
        {
            //Add a message box that pops up when picture is clicked
            MessageBox.Show("Destiny 2 one of my favourite games ever to exsist, Please Click the Data Button To Learn More!    ","Tony Powers Favourite Game");
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
