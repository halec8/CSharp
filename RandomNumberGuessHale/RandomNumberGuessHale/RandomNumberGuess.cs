using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : RandomNumberGuess
* Author      : Cody Hale
* Created     : 9/22/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : creates a random number and allows the user to guess
*               Input:  number
*               Output: if you are correct or not
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace RandomNumberGuessHale
{

    /***************************************************************
* Name        : RandomNumberGuess
* Author      : Cody Hale
* Created     : 9/22/2019
***************************************************************/
    public partial class RandomNumberGuess : Form

    {
        public int answerToGame { get; }
        Random rand = new Random();
           
            
            public RandomNumberGuess()
        {

            InitializeComponent();
            int answerToGame = rand.Next(1, 100);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {


            /**************************************************************
* Name: While Loop
* Description: allows a random number to be generated until its guessed correctly
* Input: int
* Output: when guess correctly will display a congratulation message
***************************************************************/
            int guessedNumber;
            int count = 0;

            while (count <= 1)

            {

                if (int.TryParse(userInputTextbox.Text, out guessedNumber))

                 if (guessedNumber <= answerToGame)

                {

                    MessageBox.Show("Too low try again");
                    count++;
                }

                else if (guessedNumber > answerToGame)

                {

                    MessageBox.Show("Too high, try again");
                    count++;

                }

                else if (guessedNumber == answerToGame)

                {
                    MessageBox.Show("Congratulations Thats correct!");
                    count++;
                }

                else
                {
                    MessageBox.Show("Enter a number");
                    count++;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            userInputTextbox.Text = String.Empty;
            userInputTextbox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


