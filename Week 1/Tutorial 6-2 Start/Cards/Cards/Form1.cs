using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The ShowCard method accepts a string that names
        // the selected card, and displays that card.
        private void ShowCard(string card)
        {
            switch (card)  // can use if-else if statement here also
            {
                case "Ace of Spades":
                    ShowAceSpades();
                        break;
                case "King of Clubs":
                    ShowKingClubs();
                        break;
                case "10 of Hearts":
                    ShowTenHearts();
                    break;
            }
        }

        // The ShowAceSpades method makes the Ace of Spades
        // visible and the other cards invisible.
        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        // The ShowTenHearts method makes the Ten of Hearts
        // visible and the other cards invisible.
        private void ShowTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        // The ShowKingClubs method makes the King of Clubs
        // visible and the other cards invisible.
        private void ShowKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            // If a card is selected in the ListBox, display it.
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card from " +
                                "the list box.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
