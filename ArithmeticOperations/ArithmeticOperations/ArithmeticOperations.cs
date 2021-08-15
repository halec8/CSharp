using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : ArithmeticOperationsHale
* Author      : Cody Hale
* Created     : 09/04/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program displays arithmetic operations
*               Input:  operation
*               Output: answer
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace ArithmeticOperations
{
    public partial class arithmeticOperations : Form
    {
        public arithmeticOperations()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /**************************************************************
* Name: ShowAdditionbutton
* Description: shows an addition arithmetic operation
* Input: int
* Output: string
***************************************************************/
        private void ShowAdditionbutton_Click(object sender, EventArgs e)
        {
            int answer = 10 + 10;
            String displayAnswer = "10 + 10 = " + answer.ToString();
            additionTextbox.Text = displayAnswer;
        }
        /**************************************************************
* Name: showSubtractionbutton
* Description: performs a subtraction arithmetic operation
* Input: int
* Output: string
***************************************************************/
        private void ShowSubtractionbutton_Click(object sender, EventArgs e)
        {
            int answer = 8 - 3;
            String displayAnswer = "8 - 3 = " + answer.ToString();
            subtractionTextbox.Text = displayAnswer;

        }
        /**************************************************************
* Name: showMultiplicationoperation
* Description: performs a multiplication arithmetic operation
* Input: int
* Output: String
***************************************************************/
        private void ShowMultiplicationbutton_Click(object sender, EventArgs e)
        {
            int answer = 9 * 9;
            String displayAnswer = "9 * 9 = " + answer.ToString();
            multiplicationTextbox.Text = displayAnswer;
        }
        /**************************************************************
* Name: showDivisionbutton
* Description: performs a division arithmetic operation
* Input: int
* Output: String
***************************************************************/
        private void ShowDivisionbutton_Click(object sender, EventArgs e)
        {
            int answer = 8 / 1;
            String displayAnswer = "8 / 1 = " + answer.ToString();
            divisionTextbox.Text = displayAnswer;
        }
        /**************************************************************
        * Name: showModulousbutton
        * Description: Divides and then provides the remainder
        * Input: int
        * Output: String
        ***************************************************************/
        private void ShowModulousbutton_Click(object sender, EventArgs e)
        {
            int answer = 10 % 1;
            String displayAnswer = " 10 % 1 = " + answer.ToString();
            modulousTextbox.Text = displayAnswer;
        }
        /**************************************************************
* Name: showIncreasebutton
* Description: performs a incrementation increase
* Input: int
* Output: String
***************************************************************/
        private void Showincreasebutton_Click(object sender, EventArgs e)
        {
            int answer = 5;
            String displayAnswer = "4 ++ = " + answer.ToString();
            incrementIncreasetextbox.Text = displayAnswer;
        }
        /**************************************************************
* Name: showDecreasebutton
* Description: performs incrementation decrease
* Input: int
* Output: String
***************************************************************/
        private void Showdecreasebutton_Click(object sender, EventArgs e)
        {
            int answer = 7;
            String displayAnswer = " 8 -- = " + answer.ToString();
            incrementDecreasetextbox.Text = displayAnswer;
        }
        /**************************************************************
* Name: CloseButton
* Description: closes application
* Input: int
* Output: String
***************************************************************/
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**************************************************************
* Name: Clearbutton
* Description: clears each text box
* Input: click the button
* Output: clears all text boxes
***************************************************************/
        private void ClearButton_Click(object sender, EventArgs e)
        {
            incrementIncreasetextbox.Text = String.Empty;
            incrementDecreasetextbox.Text = String.Empty;
            modulousTextbox.Text = String.Empty;
            divisionTextbox.Text = String.Empty;
            multiplicationTextbox.Text = String.Empty;
            subtractionTextbox.Text = String.Empty;
            additionTextbox.Text = String.Empty;
        }
    }
}

