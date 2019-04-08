using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The CupsToOunces method accepts a number
        // of cups as an argument and returns the
        // equivalent number of fluid ounces.


        private void convertButton_Click(object sender, EventArgs e)
        {
            // Variables to hold cups and ounces
            double cups, ounces;

            // Get the number of cups.
            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // use a method called CupsToOunces to 
                // convert the cups to ounces.

                // Display the ounces in the text box.
                ounces = cups * 8;
                ouncesLabel.Text = ounces.ToString();

            }
            else
            {
                // Display an error message.
                MessageBox.Show("Enter a valid number.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
