using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/***************************************************************
* Name        : Cards
* Author      : Cody Hale
* Created     : 9/24/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : displays the image of the card selected in the listbox.
*               Input:  user selects the card in the list box
*               Output: picture of the card is displayed
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Cards
{

    /***************************************************************
* Name        : Cards
* Author      : Cody Hale
* Created     : 9/24/2019
***************************************************************/

    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }
        /**************************************************************
* Name: ShowCard
* Description: declares the value as a string and allows the variables to be called and show the card that is called
* Input: string
* Output: card selected
***************************************************************/

        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;
                case "10 of Hearts":
                    ShowTenHearts();
                    break;
                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }

        /**************************************************************
* Name: ShowAceSpades
* Description: calls the method variable and shows the AceOfSpades card.
* Input:  must select the ace of spades text in the listbox.
* Output: ace of spades card
***************************************************************/

        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        /**************************************************************
* Name: ShowTenHearts
* Description: calls the method variable and shows the TenHearts
* Input: must select the ten of hearts text in the listbox
* Output: ten of hearts card
***************************************************************/

        private void ShowTenHearts()
        {
            tenHeartsPictureBox.Visible = true;
            aceSpadesPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;

        }

        /**************************************************************
* Name: ShowKingClubs
* Description: calls the method variable and shows the KingClubs
* Input: must select the king of clubs text in the listbox
* Output: king of clubs card
***************************************************************/

        private void ShowKingClubs()
        {
            kingClubsPictureBox.Visible = true;
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;

        }

        /**************************************************************
* Name: ShowCardButton_Click
* Description: calls whatever method is selected from the listbox
* Input: listbox selection
* Output: card that corresponds to the selection made
***************************************************************/

        private void ShowCardButton_Click(object sender, EventArgs e)
        {

            if (cardListBox.SelectedIndex != -1)
            {

                ShowCard(cardListBox.SelectedItem.ToString());

            }

            else
            {
                MessageBox.Show("Please select a card from the list box");
            }
        }

        /**************************************************************
* Name: ExitButton_Click
* Description: closes the application
***************************************************************/

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
