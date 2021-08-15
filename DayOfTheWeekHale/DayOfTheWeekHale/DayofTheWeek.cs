using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : DaysOfTheWeekHale
* Author      : Cody Hale
* Created     : 9/14/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : gets a integer from the user and displays the corresponding day of the week.
*               Input: The user inputs an integer 1-7; Any other integer displays an error
*               Output: day of the week
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace DayOfTheWeekHale
{
    public partial class dayOfTheWeek : Form
    {
        public dayOfTheWeek()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {   // declares a local variable for the program
            int number;
            /* gets the number from the user and stores it within
             the number variable */
            if (int.TryParse(numberTextBox.Text, out number))
            {   /* start of the switch method. Checks the stored
                number then displays the appropriate string
                that cooresponds*/
                switch (number)
                {
                    case 1:
                        dayDisplayLabel.Text = "Monday";
                        break;

                    case 2:
                        dayDisplayLabel.Text = "Tuesday";
                        break;

                    case 3:
                        dayDisplayLabel.Text = "Wednesday";
                        break;

                    case 4:
                        dayDisplayLabel.Text = "Thursday";
                        break;

                    case 5:
                        dayDisplayLabel.Text = "Friday";
                        break;

                    case 6:
                        dayDisplayLabel.Text = "Saturday";
                        break;

                    case 7:
                        dayDisplayLabel.Text = "Sunday";
                        break;
                        // if an invalid ineger is entered displays message
                    default:
                        dayDisplayLabel.Text = "Invalid integer";
                        break;
                }
            }
            // if no integer is entered displays the message
            else
            {
                MessageBox.Show("Enter an integer");
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {   // clears the data displayed for new data
            numberTextBox.Text = String.Empty;
            dayDisplayLabel.Text = String.Empty;
            // focus back on the number textbox.
            numberTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {   // closes the application
            this.Close();
        }

        private void DayOfTheWeek_Load(object sender, EventArgs e)
        {

        }
    }
}
