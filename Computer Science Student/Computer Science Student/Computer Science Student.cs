using System;
using System.Windows.Forms;

/***************************************************************
* Name        : Computer Science Studen
* Author      : Cody Hale
* Created     : 10/27/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Gets student name, id and the program to display the needed credit hours
*               Input:  name, id, program
*               Output: Credit hours needed
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Computer_Science_Student
{

    /***************************************************************
* Name        : CompScience
* Author      : Cody Hale
* Created     : 10/27/2019
***************************************************************/

    public partial class CompScience : Form
    {
        public CompScience()
        {
            InitializeComponent();
        }

        /**************************************************************
* Name: GetHoursButton_Click
* Description: Creates two objects and displays the required credit hours for each
* Input: name, id, program
* Output: required credit hours
***************************************************************/

        private void GetHoursButton_Click(object sender, EventArgs e)
        {
            string name, id, track;

            name = nameTextBox.Text;
            id = idTextBox.Text;

            if (infoSystemsRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }


        // closes the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
