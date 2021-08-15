using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Size = System.Drawing.Size;

/***************************************************************
* Name        : Array Argument
* Author      : Cody Hale
* Created     : 10/6/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : takes and array, displays it in a list box and saves it to a text.
                It then appends the array and displays the appended array in the list box. 
                The program then sets the array to zero and displays it in the list box and saves it to the text file.e
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Array_Argument
{

    /***************************************************************
* Name        : ArrayArgument
* Author      : Cody Hale
* Created     : 10/05/2019
***************************************************************/

    public partial class ArrayArgument : Form
    {
        public ArrayArgument()
        {
            InitializeComponent();
        }

        /**************************************************************
* Name: goButton_Click
* Description: creates an array, stores it to a txt file and then displays the array, appended array and zero'd out array to the list box.
* Output: txt file and int's to the listbox.
***************************************************************/


        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
            // Create an int array.
            int[] numbers = { 1, 2, 3 };

            StreamWriter outputFile;
            outputFile = File.CreateText("ArrayArgument.txt");

            // Display the array in the list box.
            outputListBox.Items.Add("The array's original contents:");

            WriteToFile(numbers, outputFile);

            outputFile.WriteLine("The array's original contents:");
            outputFile.Close();

            AppendArray(numbers);


            SetToZero(numbers);

            // Display the array in the list box again.
            outputListBox.Items.Add("");
            outputListBox.Items.Add("After calling SetToZero:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }

            // The SetToZero method accepts an int array as an
            // argument and sets its elememts to 0.
        }

        /**************************************************************
* Name: WriteToFile
* Description: writes the array to the txt file.
* Input: int/string/etc… , int/string/etc… field1, …
* Output: int/string/etc…, int/string/etc… field1, …
***************************************************************/

        private void WriteToFile(int[] iArray, StreamWriter outputFile)

         {
             foreach (int number in iArray)
             {
                 outputListBox.Items.Add(number);
                 outputFile.WriteLine(number);
             }
        }

        /**************************************************************
* Name: SetTiZero
* Description: sets the array to zero
* Output: 3 int's that are 0 to the txt file and listbox'
***************************************************************/

        private void SetToZero(int[] iArray)
        {
            for (int index = 0; index < iArray.Length; index++)
            {
                iArray[index] = 0;
            }
        }

        /**************************************************************
* Name: AppendArray
* Description: method to take the array and display it before setting the array to zero.
* Output: int; original array's numbers to the listbox and txt file.
***************************************************************/

        private void AppendArray(int[] inumbers)

        {
            try
            {

                const int SIZE = 3;
                int[] inum = new int[SIZE];
                int index = 0;

                StreamReader inputFile;
                inputFile = File.OpenText("ArrayArgument.txt");

                while (index < inum.Length && !inputFile.EndOfStream)
                {
                    inum[index] = int.Parse(inputFile.ReadLine());
                    index++;

                }

                inputFile.Close();

                foreach (int value in inum)
                {
                    outputListBox.Items.Add("");
                    outputListBox.Items.Add("Appended: ");
                    outputListBox.Items.Add(value);
                }
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /**************************************************************
* Name: exitButton_Click
* Description: closes the program.
***************************************************************/


        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

