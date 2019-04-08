using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilogramConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display a list of all kilograms, pounds and ounces in
        // the outputListBox when the form is loaded. Use the
        // KgToPounds and PoundsToOunces methods to accomplish
        // the conversions.
        private void Form1_Load(object sender, EventArgs e)
        {
            double pounds, ounces, kilograms;
            

            outputListBox.Items.Add("Kilograms" + "Pounds" + "Ounces");
            for (kilograms = 10; kilograms < 26; kilograms++)
            {
                pounds = KgToPounds(kilograms);
                ounces = PoundsToOunces(pounds);
                outputListBox.Items.Add( kilograms + pounds + ounces);
            }
        }
        //1 kilogram = 2.20462 pounds
        //1 pound = 16 ounces

        // This method called KgToPounds converts kilograms
        // to pounds given kilograms
        private double KgToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }

        private double PoundsToOunces(double pounds)
        {
            return pounds * 16;
        }

        // This method called PoundsToOunces converts pounds
        // to ounces given pounds

    }
}
