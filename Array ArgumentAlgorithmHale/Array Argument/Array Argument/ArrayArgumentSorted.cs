using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/***************************************************************
* Name        : Array Argument Sorted
* Author      : Cody Hale
* Created     : 10/5/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  creates an array of 15 random numbers then sorts them descending.
*               Output: message box shows the arrays sorted in descending order.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/

namespace Array_Argument
{

    /***************************************************************
* Name        : ArrayArgumentSorted
* Author      : Cody Hale
* Created     : 10/5/2019
***************************************************************/


    public partial class ArrayArgumentSorted : Form
    {
        const int ARRAY_SIZE = 15;
        int[] RandArray = new int[ARRAY_SIZE];

        public ArrayArgumentSorted()
        {
            InitializeComponent();
        }

        // Click event handler for the goButton control.

/**************************************************************
* Name: goButton_Click
* Description: creates the array of 15 random numbers
* Output: 15 random numbers to a list box
***************************************************************/


        public void goButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //const int ARRAY_SIZE = 15;
            // Create an int array.
            //int[] numbers = new int[ARRAY_SIZE];

            for (int index = 0; index < RandArray.Length; index++)
            {
                RandArray[index] = rand.Next(100);
            }

            // Display the array in the list box.
            outputListBox.Items.Add("The array's randomly generate numbers:");
            foreach (int number in RandArray)

            {
                outputListBox.Items.Add(number);

            }

        }

        /**************************************************************
* Name: FindMax
* Description: finds the maximum value of the array
* Output: displays a message box for the maximum value of the array. Displays as a string.
***************************************************************/

        private int FindMax(int[] imaximum)
        {
            int highest = 0;

            foreach (int highestNum in imaximum)
            {

                if (highestNum > highest)
                {
                    highest = highestNum;
                }

            }

            return highest;
        }

        /**************************************************************
* Name: Cody Hale
* Description: finds the minimum value of the array
***************************************************************/

        private int FindMin(int[] iminimum)
        {
            int lowest = 100;

            foreach (int minNum in iminimum)
            {
                if (minNum < lowest)
                {
                    lowest = minNum;
                }
            }

            return lowest;

        }

        /**************************************************************
* Name: exitButton_Click
* Description: Closes the program.
***************************************************************/

        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
/**************************************************************
 *  Name: FindMaxButton_Click
* Description/Output: displays a message box for the maximum value of the array.Displays as a string.
       ***************************************************************/
        private void FindMaxButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" The highest number is: " + FindMax(RandArray).ToString());
        }
/**************************************************************
* Name: FindMinButton_Click
* Description/Output: displays a message box for the minimum value of the array.Displays as a string.
***************************************************************/
        private void FindMinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The lowest number is: " + FindMin(RandArray).ToString());
        }

        /**************************************************************
* Name: SortButton_Click
* Description/Output: displays a message box for the sorted values of the array in descending order.Displays as a string.
***************************************************************/
        private void SortButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From highest to lowest the numbers are:");

            foreach (int numbers in RandArray)
            {

                Array.Sort(RandArray);
                Array.Reverse(RandArray);
                MessageBox.Show(numbers.ToString());
            }

        }

        /**************************************************************
* Name: ClearButton_Click
* Description/Output: clears the programs values for another run.
***************************************************************/
        private void ClearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            
        }
    }
}

