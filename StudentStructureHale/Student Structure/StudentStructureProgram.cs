using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/***************************************************************
* Name        : Student Structure
* Author      : Cody Hale
* Created     : 10/10/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Takes inputted info and displays it as a string within a listbox.
*               Input:  Student Name, Student ID, Major
*               Output: listbox with inputted info as a string
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Student_Structure
{
    // declares a structure called student
    struct Student
    {
        public string name;
        public int studentID;
        public string major;
    }


    /***************************************************************
* Name        : Form        
* Author      : Cody Hale
* Created     : 10/10/2019
***************************************************************/

    public partial class StudentStructureProgram : Form

    // creates a list to store the entered info
    {
        private List<Student> aStudentsInfo = new List<Student>();



        /**************************************************************
* Name: GetStudentInfo
* Description: gets the information from the user and stores into variables that are used later
* Input: string, string, int.
* Output: strings
***************************************************************/


        private void GetStudentInfo(ref Student studentInfo)
        {

            try
            {
                studentInfo.name = nameTextBox.Text;
                studentInfo.studentID = int.Parse(studentIDTextBox.Text);
                studentInfo.major = majorTextBox.Text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
        }

        public StudentStructureProgram()
        {
            InitializeComponent();
        }

        private void StudentStructureProgram_Load(object sender, EventArgs e)
        {

        }

        /**************************************************************
* Name: CreateStudentButton_Click
* Description: stores info into the list
* Input: string, string int
***************************************************************/


        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            Student theStudentsInfo = new Student();

            GetStudentInfo(ref theStudentsInfo);

            aStudentsInfo.Add(theStudentsInfo);

            nameTextBox.Clear();
            studentIDTextBox.Clear();
            majorTextBox.Clear();

        }


        /**************************************************************
* Name: DisplayButton_Click
* Description: displays input info into the listbox
* Input: string, string, int
* Output: string
***************************************************************/


        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string output;

            foreach (Student theStudentsInfoStudent in aStudentsInfo)
            {

                displaysInfoListBox.Items.Clear();

                output = theStudentsInfoStudent.name + "'s" + " student ID number is " + theStudentsInfoStudent.studentID +
                         " and has a major of " +
                         theStudentsInfoStudent.major;

                displaysInfoListBox.Items.Add(output);
            }

        }


        /**************************************************************
* Name: HelpToolStripMenuItem_Click
* Description: Tells the user whom wrote the program and the steps to operate
* Output: string
***************************************************************/


        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)

        {

            MessageBox.Show("This program was built by Cody Hale on 10.10.2019 " +
            "                               " +
            "Step1: Please enter a student name, student ID number and a student's major" + 
            "                                              " +
            "                                                                   " +
            " Step2: Click the 'Create Student' button." +
            "                                                    " +
            " Step3: Please click the display button to show what was entered");
        }

        /**************************************************************
* Name: ExitButton_Click
* Description: Closes the program.
***************************************************************/


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
