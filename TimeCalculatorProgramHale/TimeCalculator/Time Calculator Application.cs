using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : TimeCalculatorHale
* Author      : Cody Hale
* Created     : 9/14/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Gets seconds from the user and displays hours, minutes, days, seconds
*               Input:  seconds
*               Output: hours, minutes, days or seconds
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace TimeCalculator
{
    public partial class timeCalculator : Form
    {
        public timeCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // declares local variables
            double seconds;
            double minutes = 60;
            double hours = 3600;
            double days = 86400;
            // gets user input for seconds and stores into seconds variable
            if (double.TryParse(secondsTextBox.Text, out seconds))
            {
                if (double.TryParse(secondsTextBox.Text, out seconds))
                { /* if seconds falls within a certain parameter
                    it will convert seconds to minutes and display
                    as a string */
                    if (seconds >= 60 && seconds <= 3599)
                    {
                        minutesDisplayLabel.Text = (seconds / minutes).ToString();
                    }
                    /* if seconds falls within a certain parameter it will
                     convert seconds to hours and display as a string */
                    else if (seconds >= 3600 && seconds <= 86399)
                    {
                        hoursDisplayLabel.Text = (seconds / hours).ToString();
                    }
                    /* if seconds falls over a certain threshold it will
                     convert seconds to days and display as a string */
                    else if (seconds >= 86400)
                    {
                        daysDisplayLabel.Text = (seconds / days).ToString();
                    }
                    /* if seconds doesn't fit into any of the above parameters
                     it will display the seconds as seconds but the seconds
                     will be displayed as a string */
                    else if (seconds <= 0 && seconds <= 59)
                    {
                        secondsDisplayLabel.Text = seconds.ToString();
                    }
                }
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        // this closes the statement
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        /* this clears the application and then
         refocuses on the seconds text box */
        {
            daysDisplayLabel.Text = String.Empty;
            hoursDisplayLabel.Text = String.Empty;
            minutesDisplayLabel.Text = String.Empty;
            secondsTextBox.Text = String.Empty;
            secondsDisplayLabel.Text = String.Empty;
            secondsTextBox.Focus();
        }
    }
}

