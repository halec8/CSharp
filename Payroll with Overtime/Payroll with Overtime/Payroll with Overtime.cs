using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

/***************************************************************
* Name        : PayrollWithOvertimeHale
* Author      : Cody Hale
* Created     : 913/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : receives user input for hours and pay then determines the base salary or what their salary would be if they did work overtime.
*               Input:  Hours worked and pay
*               Output: gross pay
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/

namespace Payroll_with_Overtime
{
    public partial class payrollAndovertime : Form
    {
        public payrollAndovertime()
        {
            InitializeComponent();
        }

        /**************************************************************
* Name: CalculateButton_Click
* Description: determines gross pay after user inputs data
* Input: hours worked and base pay rate
* Output: gross pay with or without overtime
***************************************************************/

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // declares constants used in the application
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                // declares local variables used in the application
                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                // gets the stored input from the user

                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hoursWorked > BASE_HOURS)
                {
                    // calculates variables and provides gross pay with overtime
                    basePay = hourlyPayRate * BASE_HOURS;
                    overtimeHours = hoursWorked - BASE_HOURS;
                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    // gives gross pay without overtime
                    grossPay = hoursWorked * hourlyPayRate;

                }
                // displays pay
                grossPayLabel.Text = grossPay.ToString("c");

            }
            // returns an error message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PayrollAndovertime_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // clears the data inputted
            hoursWorkedTextBox.Text = String.Empty;
            hourlyPayRateTextBox.Text = String.Empty;
            grossPayLabel.Text = String.Empty;

            // refocuses to the hoursWorkedTextBox
            hoursWorkedTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // closes the entire application
            this.Close();
        }
    }
}
