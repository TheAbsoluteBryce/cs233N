using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program7_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string userSymbol = "X";
        const string computerSymbol = "O";
        const string empty = "";
        int userWins = 0;            // count user wins
        int computerWins = 0;        // count computer wins
        int countTies = 0;           // count ties

        private Label GetSquare(int row, int column)
        {
            int labelNumber = row * 3 + column + 1;
            return (Label)(this.Controls["label" + labelNumber.ToString()]);
        }

        private void GetRowAndColumn(Label l, out int row, out int column)
        {
            int position = int.Parse(l.Name.Substring(5));     // set position to integer value of sixth character of the label's name, ex: 9 for label9
            row = (position - 1) / 3;                          // row gets the whole number result of the integer divsion of (position -1) / 3 
            column = (position - 1) % 3;                       // column gets remainder of the integer divsion of (position -1) / 3
            //uses the # of the label to determine where the row/column is
        }

        private void ResetBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Label l = GetSquare(r, c);
                    l.Text = "";
                    l.Enabled = true;
                    l.ForeColor = Color.Black;
                }
            }
        }

        private void HighlightColumn(int col)
        {
            for (int row = 0; row < 3; row++)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }

        private void HighlightDiagonal1()
        {
            for (int col = 0; col < 3; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    Label square = GetSquare(row, col);
                    square.Enabled = true;
                    square.ForeColor = Color.Red;
                }
            }

        }

        private void HighlightDiagonal2()
        {
            for (int col = 2; col >= 0; col--)
            {
                for (int row = 0; row < 3; row++)
                {
                    Label square = GetSquare(row, col);
                    square.Enabled = true;
                    square.ForeColor = Color.Red;
                }
            }
        }

        private void HighlightRow(int row)
        {
            for (int col = 0; col < 3; col++)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }
        
        private void MakeComputerMove()
        {
            int row, col;
            Label selectedLabel;
            Random rNG = new Random();
            do
            {
                row = rNG.Next(0, 3);
                col = rNG.Next(0, 3);
                selectedLabel = GetSquare(row, col);
            }
            while (selectedLabel.Text != empty);
            
            
            selectedLabel.Text = computerSymbol.ToString();
            selectedLabel.Enabled = false;
      
            if (IsWinner())
            {
                 MessageBox.Show("Computer win!");
                 computerWins++;
                 label10.Text = "User: " + userWins + "  Computer: " + computerWins + "  Ties: " + countTies;
            }
            else if (IsFull())
            {
                MessageBox.Show("It's a Tie!");
                countTies++;
                label10.Text = "User: " + userWins + "  Computer: " + computerWins + "  Ties: " + countTies;
            }
            
            }
        // do
        //      pick a random number between 0 and 2 for row
        //      and another random number between 0 and 2 for column     
        //      use GetSquare method to "find" the label at row, column
        // Repeat this process if that square has a value in it

        // set the text to the computer's symbol
        // disable the square
        // if computer won (IsWinner)
        //    display a message box
        //    increment number of computer wins
        //    output summary of wins
        // else if it's a tie 
        //    display a message box
        //    increment number of ties
        //    output summary of wins


        private bool IsRowWinner(int row)
        {
            if (GetSquare(row, 0).Text == GetSquare(row, 1).Text &&
                GetSquare(row, 1).Text == GetSquare(row, 2).Text &&
                GetSquare(row, 0).Text != empty)
            {
                HighlightRow(row);
                return true;
            }
            else
            {
                return false;
            }
            
            // if square(row, 0) = square(row, 1) = square(row, 2) AND square(row, 0) is not empty
            //      highlight the row
            //      return true
            // else
            //      return false
        }

        private bool IsAnyRowWinner()
        {
            bool winner = false;
            for (int row = 0; row < 3; row++)
            {
                if (IsRowWinner(row))
                    winner = true;
            }
            return winner;
        }

        private bool IsColumnWinner(int col)
        {
            if (GetSquare(0, col).Text == GetSquare(1, col).Text &&
                GetSquare(1, col).Text == GetSquare(2, col).Text &&
                GetSquare(0, col).Text != empty)
            {
                HighlightColumn(col);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsAnyColumnWinner()
        {
            bool winner = false;
            for (int col = 0; col < 3; col++)
            {
                if (IsColumnWinner(col))
                    winner = true;
            }
            return winner;
        }

        private bool IsAnyDiagonalWinner()
        {
            if (GetSquare(0, 0).Text == GetSquare(1, 1).Text &&
                GetSquare(1, 1).Text == GetSquare(2, 2).Text &&
                GetSquare(0, 0).Text != empty)
            {
                HighlightDiagonal1();
                return true;
            }
            else if (GetSquare(2, 0).Text == GetSquare(1, 1).Text &&
                GetSquare(1, 1).Text == GetSquare(0, 2).Text &&
                GetSquare(0, 2).Text != empty)
            {
                HighlightDiagonal2();
                return true;
            }
            else
            {
                return false;
            }
            
                


        }

        private bool IsWinner()
        {
            if (IsAnyRowWinner() || IsAnyColumnWinner() || IsAnyDiagonalWinner())
            {
                return true;
            }
            else
            {
                return false;
            }
            //if any row is a winner return true
            //if any column is a winner return true
            //if any diagonal is a winner return true
            //else return false
        }

        private bool IsFull()
        {
            for (int row = 0; row < 3; row++)
                for (int col = 0; col < 3; col++)
                {
                    Label lab = GetSquare(row, col);

                    if (lab.Text == empty)
                    {
                        return false;
                    }
                }
            return true;
        }

        private void label_DoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            if (clickedLabel.Text == "")
            {
                int row, column;
                GetRowAndColumn(clickedLabel, out row, out column);

                clickedLabel.Text = userSymbol.ToString();
                clickedLabel.Enabled = false;                // disable the square so it cannot be selected by the user again

                if (IsWinner())
                {
                    MessageBox.Show("You win!");
                    userWins++;
                    label10.Text = "User: " + userWins + "  Computer: " + computerWins + "  Ties: " + countTies;
                }
                else if (IsFull())
                {
                    MessageBox.Show("It's a Tie!");
                    countTies++;
                    label10.Text = "User: " + userWins + "  Computer: " + computerWins + "  Ties: " + countTies;
                }
                else
                    MakeComputerMove();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
