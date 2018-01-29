using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_verification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int ageInput;

            ageInput = Convert.ToInt32(txtEnterAge.Text);

            if (ageInput <= 18)
            {
                lblResult.Text = "You are a miner";
                if(ageInput >= 14)
                {
                 lblOtherResult.Text = "You are in High School and you smell.";
                }
                else
                {
                 lblOtherResult.Text = "You are to small to insult";
                }
            }
            if(ageInput >= 21)
            {
             lblResult.Text = "Congratulation you no longer smell";
             if (ageInput == 21)
             {
              lblOtherResult.Text = "You are old enough to drink but you probably should not.";
             }
            }
            if (ageInput < 21 && ageInput > 35)
            {
             lblResult.Text = "You are having a quarter life crises.";
            }
            {
             lblOtherResult.Text = "You are no longer having half life crises";
            }
            if (ageInput < 46 && ageInput > 55)
            {
             lblResult.Text = "You should get a better phone";
            }
            {
             lblOtherResult.Text = "You can pick from IPhone7plus or IPhoneX";
            }
            if (ageInput < 55 && ageInput > 75)
            {
             lblResult.Text = "You should get a good computer";
            }
            {
             lblOtherResult.Text = "Apple desktop or IMaclaptop";
            }
            if (ageInput >= 75)
            {
             lblResult.Text = "Go visit your family";
             if(ageInput == 100)
                {
                 lblOtherResult.Text = "Your family should visit you";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//if greater that 14 say something
//if less than 14 say something
//Add onto this program for ages 26-35
//46-55
//56 - 75
//75+
