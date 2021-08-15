using System;
using System.CodeDom;
using System.Data;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

/***************************************************************
* Name        : TestScoreAppHale
* Author      : Cody Hale
* Created     : 10/05/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 190
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  gets user input for 3 persons test scores
*               Output: Displays the average test score for each person.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace TestScoreAppHale
{
    /***************************************************************
* Name        : Program
* Author      : Cody Hale
* Created     : 10/05/2019
***************************************************************/

    internal class Program
    {
        
/**************************************************************
* Name: Main
* Description: main method that gets user input, stores within a jagged array and then processes to get the average test score per person.
* Input: int/test scores
* Output: int test scores averages
***************************************************************/

        private static void Main(string[] args)
        {
            //creates a constant 3 for the row size
            const int ROW = 3;


            // creates a jagged array with 3 rows and the column sizes of 3, 5 and 4
            int[][] testScores = new int[ROW][];

            testScores[0] = new int[3];
            testScores[1] = new int[5];
            testScores[2] = new int[4];


            /* for loop to prompt the user to enter a test for each available index
             in the array MorgansTestScores. It then stores the user input
             until the index is the same as the array length. */

            for (int row = 0; row < testScores.Length; row++)
            {

                for (int col = 0; col < testScores[row].Length; col++)
                {
                    Console.WriteLine("Enter test scores: ");
                    testScores[row][col] = int.Parse(Console.ReadLine());
                }
            }

            // declares variables to hold the test score averages
            int morganTestScores = 0;
            int bowieTestScores = 0;
            int anayaTestScores = 0;


            // for loop to process the total of each row

            for (int row = 0; row < testScores.Length; row++)
            {
                morganTestScores += testScores[0][row];
                bowieTestScores += testScores[1][row];
                anayaTestScores += testScores[2][row];

            }
            // assigns the sum of the rows and divides by the columns
            morganTestScores = morganTestScores / 3;
            bowieTestScores = bowieTestScores / 5;
            anayaTestScores = anayaTestScores / 4;

            // displays the average of each person's test scores within the console.

            Console.WriteLine("Morgan's average test score are: " + morganTestScores);
            Console.WriteLine("Bowies average test scores are: " + bowieTestScores);
            Console.WriteLine("Anaya's average test scores are: " + anayaTestScores);
            
            // prompts the user to exit

            Console.WriteLine("Press any key to exit");

            // keeps the console open so that after the averages are displayed the console isn't automatically closed without the user's choice.

            Console.ReadLine();

            // clears the console.

            Console.Clear();

        }
    }
}


