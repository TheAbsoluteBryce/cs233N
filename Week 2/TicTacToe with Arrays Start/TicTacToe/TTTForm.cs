using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TTTForm : Form
    {
        public TTTForm()
        {
            InitializeComponent();
        }

        const string USER_SYMBOL = "X";
        const string COMPUTER_SYMBOL = "O";
        const string EMPTY = "";

        const int SIZE = 5;

        // constants for the 2 diagonals
        const int TOP_LEFT_TO_BOTTOM_RIGHT = 1;
        const int TOP_RIGHT_TO_BOTTOM_LEFT = 2;

        // constants for IsWinner
        const int NONE = -1;
        const int ROW = 1;
        const int COLUMN = 2;
        const int DIAGONAL = 3;

        // TODO: declare a 2-dim array that holds the Xs and Os
        

        // This method takes a row and column as parameters and 
        // returns a reference to a label on the form in that position
        private Label GetSquare(int row, int column)
        {
            int labelNumber = row * SIZE + column + 1;
            return (Label)(this.Controls["label" + labelNumber.ToString()]);
        }

        // This method does the "reverse" process of GetSquare
        // It takes a label on the form as it's parameter and
        // returns the row and column of that square as output parameters
        private void GetRowAndColumn(Label l, out int row, out int column)
        {
            int position = int.Parse(l.Name.Substring(5));
            row = (position - 1) / SIZE;
            column = (position - 1) % SIZE;
        }

        // This method takes a row (in the range of 0 - 4) and returns true if 
        // the row on the form contains 5 Xs or 5 Os.
        // Use it as a model for writing IsColumnWinner
        private bool IsRowWinner(int row)
        {
            string symbol = board[row, 0];
            for (int col = 1; col < SIZE; col++)
            {
                if (symbol == EMPTY || board[row, col] != symbol)
                    return false;
            }
            return true;
        }

        // TODO: write IsColumnWinner
        private bool IsColumnWinner(int col)
        {

        }

        // This method returns true if the left to right diagonal
        // is a winner
        private bool IsDiagonal1Winner()
        {
            string symbol = board[0, 0];
            for (int row = 1, col = 1; row < SIZE; row++, col++)
            {
                if (symbol == EMPTY || board[row, col] != symbol)
                    return false;
            }
            return true;
        }

        // TODO: write IsDiagonal2Winner
        // This method returns true if the rigth to left diagonal
        // is a winner
        private bool IsDiagonal2Winner()
        {

        }

        // to do: write IsFull method
        // This method returns true if all elements in the 
        // 2-dim array have an "X" or an "O"
        private bool IsFull()
        {

        }

        // This method determines if any row, column or diagonal on the board is a winner.
        // It returns true or false and the output parameters will contain appropriate values
        // when the method returns true.  See constant definitions at top of form.
        private bool IsWinner(out int whichDimension, out int whichOne)
        {
            // rows
            for (int row = 0; row < SIZE; row++)
            {
                if (IsRowWinner(row))
                {
                    whichDimension = ROW;
                    whichOne = row;
                    return true;
                }
            }
            // columns
            for (int column = 0; column < SIZE; column++)
            {
                if (IsColumnWinner(column))
                {
                    whichDimension = COLUMN;
                    whichOne = column;
                    return true;
                }
            }
            // diagonals
            if (IsDiagonal1Winner())
            {
                whichDimension = DIAGONAL;
                whichOne = TOP_LEFT_TO_BOTTOM_RIGHT;
                return true;
            }
            if (IsDiagonal2Winner())
            {
                whichDimension = DIAGONAL;
                whichOne = TOP_RIGHT_TO_BOTTOM_LEFT;
                return true;
            }
            whichDimension = NONE;
            whichOne = NONE;
            return false;
        }

        // I wrote this method to show you how to call IsWinner
        private bool IsTie()
        {
            int winningDimension, winningValue;
            return (IsFull() && !IsWinner(out winningDimension, out winningValue));
        }

        // This method takes an integer in the range 0 - 2 that represents a column
        // as it's parameter and changes the font color of that cell to red.
        private void HighlightColumn(int col)
        {
            for (int row = 0; row < SIZE; row++)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }

        private void HighlightDiagonal(int whichDiagonal)
        {
            if (whichDiagonal == TOP_LEFT_TO_BOTTOM_RIGHT)
                HighlightDiagonal1();
            else
                HighlightDiagonal2();

        }

        private void HighlightDiagonal2()
        {
            for (int row = 0, col = SIZE - 1; row < SIZE; row++, col--)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }


        private void HighlightRow(int row)
        {
            for (int col = 0; col < SIZE; col++)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }

        private void HighlightDiagonal1()
        {
            for (int row = 0, col = 0; row < SIZE; row++, col++)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }


        private void HighlightWinner(string player, int winningDimension, int winningValue)
        {
            switch (winningDimension)
            {
                case ROW:
                    HighlightRow(winningValue);
                    resultLabel.Text = (player + " wins!");
                    break;
                case COLUMN:
                    HighlightColumn(winningValue);
                    resultLabel.Text = (player + " wins!");
                    break;
                case DIAGONAL:
                    HighlightDiagonal(winningValue);
                    resultLabel.Text = (player + " wins!");
                    break;
            }
        }


        // TODO: write SyncArrayAndSquare
        // It should set the text property of each square in the UI to the value in the corresponding element of the array
        // and disable the squares that are not empty (you don't have to enable the others because they're enabled by default.
        private void SyncArrayAndSquares()
        {

        }

        //* TODO:  write ResetSquares
        // This method sets the foreground color of all squares
        // to black
        private void ResetSquares()
        {

        }

        //* TODO:  write ResetArray
        // Reinitialize the 2-dim array so no Xs or Os
        private void ResetArray()
        {

        }

        private void MakeComputerMove()
        {
            Random gen = new Random();
            int row;
            int column;
            do
            {
                row = gen.Next(0, SIZE);
                column = gen.Next(0, SIZE);
            } while (board[row, column] != EMPTY);
            board[row, column] = COMPUTER_SYMBOL;
        }

        // TODO: write DisableAllSquares
        // Setting the enabled property changes the look and feel
        // of the label. In the previous TicTacToe program we
        // set the enabled property to false to prevent clicking
        // a label. However now instead, where going to remove the
        // event handler from each square by calling 
        // DisableSquare for each label.
        private void DisableAllSquares()
        {

        }

        // Inside the click event handler you have a reference to the label that was clicked
        // Use this method (and pass that label as a parameter) to disable just that one square
        private void DisableSquare(Label square)
        {
            square.Click -= new System.EventHandler(this.label_Click);
        }

        // You'll need this method to allow the user to start a new game
        private void EnableAllSquares()
        {
            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {
                    Label square = GetSquare(row, col);
                    square.Click += new System.EventHandler(this.label_Click);
                }
            }
        }


        private void label_Click(object sender, EventArgs e)
        {
            int winningDimension = NONE;
            int winningValue = NONE;
            int row, column;

            Label clickedLabel = (Label)sender;
            GetRowAndColumn(clickedLabel, out row, out column);
            board[row, column] = USER_SYMBOL;
            SyncArrayAndSquares();

            if (IsWinner(out winningDimension, out winningValue))
            {
                HighlightWinner("The User", winningDimension, winningValue);
                DisableAllSquares();
            }
            else if (IsFull())
            {
                resultLabel.Text = "It's a Tie.";
            }
            else
            {
                MakeComputerMove();
                SyncArrayAndSquares();
                if (IsWinner(out winningDimension, out winningValue))
                {
                    HighlightWinner("The Computer", winningDimension, winningValue);
                    DisableAllSquares();
                }
                else if (IsFull())
                {
                    resultLabel.Text = "It's a Tie.";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetArray();
            SyncArrayAndSquares();
            ResetSquares();
            EnableAllSquares();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TTTForm_Load(object sender, EventArgs e)
        {
            ResetArray();
        }
    }
}
