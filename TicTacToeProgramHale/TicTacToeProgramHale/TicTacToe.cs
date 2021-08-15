using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

/***************************************************************
* Name        : TicTacToeHale
* Author      : Cody Hale
* Created     : 10/06/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  Allows user to select a button and displays "X" or "O"
                        displays a winner when 3 "x's" or 3 "o's" are
                        in a row vertically, horizontally or diagonally.
*               Output: displays a message showing who won the game
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace TicTacToeProgramHale
{ 
    /***************************************************************
 * Name        : TicTacToe
 * Author      : Cody Hale
 * Created     : 10/6/2019
 ***************************************************************/

    public partial class TicTacToe : Form
    {
        bool turn = true;
        int turnCounter = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        /**************************************************************
* Name: ExitButton_Click
* Description: button to close the program
***************************************************************/

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /**************************************************************
* Name: ExitGameToolStripMenuItem_Click
* Description: Option within the toolstrip menue to close the program
***************************************************************/

        private void ExitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /**************************************************************
* Name: button_click
* Description: each button is clickable and if its X's turn the button
               will display an x. If its O's turn the button will
               display an O. If there are 3 X's or 3 O's in a row
               the program will display a winner.
* Input: strings
* Output: strings
***************************************************************/

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;

            checkWinner();
        }


        /**************************************************************
* Name: Check Winner
* Description: Function that checks who won the game
         *
***************************************************************/
        
        private void checkWinner()
        {
            bool winner = false;


            // check horizontal buttons for a winner
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                winner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                winner = true;
            if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                winner = true;

            //check vertical buttons for a winner

            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                winner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                winner = true;
            if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                winner = true;


            // check diagonal buttons for a winner


            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                winner = true;
            else if ((c1.Text == b2.Text) && (b2.Text == a3.Text) && (!c1.Enabled))
                winner = true;



            if (winner)
            {
                string win = "";

                if (turn)
                    win = "O ";
                else
                    win = "X ";

                MessageBox.Show(win + "Wins The Game!");

            }
            else
            {
                if (turnCounter == 9)
                {
                    MessageBox.Show("The game is a draw!");
                }
            }
        }


        /**************************************************************
* Name: disableButtons
* Description: disables the buttons that are selected so they can't
               be selected again.
***************************************************************/

        private void disableButtons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button) c;
                    b.Enabled = false;
                }
            }

            catch
            {

            }
        }


        /**************************************************************
* Name: ClearBoard_Click
* Description: clears the board for a new game to begin.
***************************************************************/

        private void ClearBoard_Click(object sender, EventArgs e)
        {

            turn = true;
            turnCounter = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button) c;
                    b.Enabled = true;
                    b.Text = "";

                }
            }
            catch
            {

            }
        }


        /**************************************************************
* Name: NewGameToolStripMenuItem_Click
* Description: clears the board for a new game to begin.
***************************************************************/

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCounter = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
            }
            catch
            {

            }
        }
    }
}

        