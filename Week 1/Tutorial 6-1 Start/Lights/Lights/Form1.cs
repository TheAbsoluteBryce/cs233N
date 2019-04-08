using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void switchButton_Click(object sender, EventArgs e)
        {
            // Reverse the state of the light.
            if (lightOnPictureBox.Visible == true)
            {
                lightOffPictureBox.Visible = true;
                lightOnPictureBox.Visible = false;
                lightStateLabel.Text = "Off";
                // Turn the light off
            }
            else
            {
                lightOffPictureBox.Visible = false;
                lightOnPictureBox.Visible = true;
                lightStateLabel.Text = "On";

                // Turn the light on
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
