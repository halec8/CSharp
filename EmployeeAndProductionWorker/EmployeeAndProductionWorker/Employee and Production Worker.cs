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
* Name        : EmployeeAndProductionWorker
* Author      : Cody Hale
* Created     : 10/27/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  input name, employee number, shift, hourly rate and shift
*               Output: entered data outputted/displayed
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace EmployeeAndProductionWorker
{
    public partial class EmployeeAndProductionWorker : Form
    {
        public EmployeeAndProductionWorker()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // closes the application

            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            // clears the application and puts the focus on the nameTextBox
            nameTextBox.Text = String.Empty;
            employeeNumTextbox.Text = String.Empty;
            hourlyRateTextbox.Text = String.Empty;
            displayedShiftWorked.Text = String.Empty;
            displayedEmployeeNumLabel.Text = String.Empty;
            displayedHourlyRate.Text = String.Empty;
            displayedNameLabel.Text = String.Empty;

            nameTextBox.Focus();
        }


        /**************************************************************
* Name: SubmitButton_Click
* Description: creates two objects and displays then
* Input: string, int, decimal
* Output: string, int, decimal
***************************************************************/


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // local variables used to display the employee number and hourly rate

            int num;
            decimal hourlyRate;

            // creates two objects
            Employee myEmployee = new Employee();
            ProductionWorker myProductionWorker = new ProductionWorker();

            // assigns the entered data to the objects
            myEmployee.Name = nameTextBox.Text;
            if (int.TryParse(employeeNumTextbox.Text, out num))
            
                if (decimal.TryParse(hourlyRateTextbox.Text, out hourlyRate))
                {
                   
                    myProductionWorker.HourlyRate = hourlyRate;
                     myEmployee.EmployeeNumber = num;
                }
                else
                {
                    MessageBox.Show("Invalid hourly rate");
                }
            else
            {
                MessageBox.Show("Invalid employee number");
            }


            // Displays the inputted data

            displayedEmployeeNumLabel.Text = num.ToString();
            displayedNameLabel.Text = myEmployee.Name;
            displayedHourlyRate.Text = myProductionWorker.HourlyRate.ToString();

            if (firstShiftRadiobutton.Checked)
            {
                myProductionWorker.Shift = 1;
                displayedShiftWorked.Text = myProductionWorker.Shift.ToString();
            }
            else
            {
                myProductionWorker.Shift = 2;
                displayedShiftWorked.Text = myProductionWorker.Shift.ToString();
            }

        }

    }
}

