using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The ReadScores method reads the scores from the
        // TestScores.txt file into the scoresList parameter.
        private void ReadScores(List<int> scoresList)
        {
            try
            {
                // Open the TestScores.txt file.
                StreamReader inputFile = File.OpenText("TestScores.txt");

                // Read the scores into the list.
                while (!inputFile.EndOfStream)
                {
                    // TODO:  add the current score from the file into the list
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        // The DisplayScores method displays the contents of the
        // scoresList parameter in the ListBox control.
        private void DisplayScores(/* TODO:  add the parameter here */)
        {
            // TODO:  iterate through the list
            // add each item from the list to the list box
        }

        // The Average method returns the average of the values
        // in the scoresList parameter.
        private double Average(/* TODO:  add the parameter here */)
        {
            int total = 0;      // Accumulator
            double average;     // To hold the average

            // TODO:  Calculate the total of the scores.

            // Calculate the average of the scores.

            // Return the average.
            return average;
        }

        // The AboveAverage method returns the number of
        // above average scores in scoresList.
        private int AboveAverage(/* TODO:  add the parameter here */)
        {
            int numAbove = 0;       // Accumulator

            // TODO:  Get the average score.

            // TODO:  Count the number of above average scores.

            // Return the number of above average scores.
            return numAbove;
        }

        // The BelowAverage method returns the number of
        // below average scores in scoresList.
        private int BelowAverage(/* TODO:  add the parameter here */)
        {
            int numBelow = 0;       // Accumulator

            // TODO:  Get the average score.

            // TODO:  Count the number of below average scores.

            // Return the number of below average scores.
            return numBelow;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // To hold the average score
            int numAboveAverage;    // Number of above average scores
            int numBelowAverage;    // Number of below average scores

            // TODO:  Create a List to hold the scores.

            // TODO:  Read the scores from the file into the List.

            // TODO:  Display the scores.

            // TODO:  Display the average score.
            averageLabel.Text = averageScore.ToString("n1");

            // TODO:  Display the number of above average scores.
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // TODO:  Display the number of below average scores.
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
