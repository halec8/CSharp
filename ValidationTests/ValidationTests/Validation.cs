using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


/***************************************************************
* Name        : Validation
* Author      : Cody Hale
* Created     : 11/17/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Allows user to input data into the respective fields. If the data isn't appropriate then an exception is thrown.
*               Input:  Strings
*               Output: if valid the strings get displayed within a listbox
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace ValidationTests
{

    /***************************************************************
* Name        : Validation
* Author      : Cody Hale
* Created     : 11/17/2019
***************************************************************/

    public partial class Validation : Form
    {
        public Validation()


        {
            InitializeComponent();
        }


        /**************************************************************
* Name: exitButton_Click
* Description: closes the program
***************************************************************/

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /**************************************************************
* Name: ClearButton_Click
* Description: clears the gui's entered daya and re-focuses on student ID
***************************************************************/


        private void clearButton_Click(object sender, EventArgs e)
        {
            studentIDTextBox.Text = string.Empty;
            studentFirstNameTextBox.Text = string.Empty;
            studentLastNameTextBox.Text = string.Empty;
            classCRNTextBox.Text = string.Empty;
            classCodeAndNumberTextBox.Text = string.Empty;

            validationListBox.Items.Clear();

            studentIDTextBox.Focus();
        }

        /**************************************************************
* Name: ValidateStudentId
* Description: Takes the user input and validates for the student ID field has to be a certian pattern or it throws an exception
* Input: string
* Output: once validated the string is displayed in the listbox
***************************************************************/


        public string ValidateStudentId(string enteredStudentId)
        {

            var studentIdNumber = studentIDTextBox.Text;

            if (Regex.IsMatch(studentIdNumber, "^[0-9]{1,9}$"))
            {
                return enteredStudentId;
            }

            throw new ArgumentException("Enter a valid student ID number. It must be numeric and only 9 values.");
        }

        /**************************************************************
* Name: ValidateFirstName
* Description: Validates the entered input in the first name field. Has to be a certain pattern or an exception is thrown
* Input: string
* Output: if validated the string is displayed in the list box
***************************************************************/


        public string ValidateFirstName(string firstName)

        {
            var studenFirstName = studentFirstNameTextBox.Text;

            if (Regex.IsMatch(studenFirstName, "^[A-Z][a-zA-Z .,'-]*$"))
            {
                return firstName;
            }

            throw new ArgumentException("Please enter a valid first name.");
        }



        /**************************************************************
* Name: Validate Last Name
* Description: Validates the entered input from the last name field. If its not a certain pattern an exception is thrown.
* Input: string
* Output: if validated then the string is displayed in a list box
***************************************************************/


        public string ValidateLastName(string lastName)

        {

            var studentLastName = studentLastNameTextBox.Text;

            if (Regex.IsMatch(studentLastName, "^[A-Z][a-zA-Z .,'-]*$"))
            {
                return lastName;
            }

            throw new ArgumentException("Please enter a valid last name.");

        }


        /**************************************************************
* Name: ValidateClassCrn
* Description: Validates user input from the class crn field. If its not a certain pattern then an exception is thrown.
* Input: string
* Output: if validated the string is displayed in the list box
***************************************************************/



        public string ValidateClassCrn(string classCrn)
        { 
        var classCrnNumber = classCRNTextBox.Text;

            if (Regex.IsMatch(classCrnNumber, "^[0-9]{1,5}$"))
        {
            return classCrn;
        }


        throw new ArgumentException("Enter a valid class CRN number. It must be numeric and only 5 values.");
    }


        /**************************************************************
* Name: ValidateClassCodeAndNumber
* Description: Validates user input from the class code and number field. If its not a certain pattern an exception is thrown.
* Input: string
* Output: if validated then the string is displayed in a list box
***************************************************************/



        public string ValidateClassCodeAndNumber(string classCodeAndNumber)
        {
            var enteredClassCodeAndNumber = classCodeAndNumberTextBox.Text;

            if (Regex.IsMatch( enteredClassCodeAndNumber, "^[A-Z]{1,3}..[0-9]{1,3}$"))
            {
                return classCodeAndNumber;
            }

            throw new ArgumentException("Enter a valid class code and number. The first code is 3 letters and the class number is 3 numbers.");
        }


        /**************************************************************
* Name: validateButton_Click
* Description: calls all the methods and if valid user input was entered all fields are displayed in a list box.

***************************************************************/


        public void validateButton_Click(object sender, EventArgs e)
        {
            var validStudentId = studentIDTextBox.Text;
            var validFirstName = studentFirstNameTextBox.Text;
            var validLastName = studentLastNameTextBox.Text;
            var validCrn = classCRNTextBox.Text;
            var validClassCodeAndNumber = classCodeAndNumberTextBox.Text;


            var studentIdIsValid = ValidateStudentId(validStudentId);
            var firstNameIsValid = ValidateFirstName(validFirstName);
            var lastNameIsValid = ValidateLastName(validLastName);
            var crnIsValid = ValidateClassCrn(validCrn);
            var classCodeAndNumberIsValid = ValidateClassCodeAndNumber(validClassCodeAndNumber);

            validationListBox.Items.Add("Student ID: " + studentIdIsValid);
            validationListBox.Items.Add("First Name: " + firstNameIsValid);
            validationListBox.Items.Add("Last Name: " + lastNameIsValid);
            validationListBox.Items.Add("Class CRN Number: " + crnIsValid);
            validationListBox.Items.Add("Class Code and Number: " + classCodeAndNumberIsValid);
        }
    }
}


