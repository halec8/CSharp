using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

/***************************************************************
* Name        : FriendFileHale
* Author      : Cody Hale
* Created     : 09/20/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  user enters their friends names (no numbers allowed)
*               Output: list of names from start to finish
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Friend_File
{
    /***************************************************************
* Name        : Friend File
* Author      : Cody Hale
* Created     : 9/20/2019
***************************************************************/

    public partial class FriendFile : Form
    {
        public FriendFile()
        {
            InitializeComponent();
        }

        /**************************************************************
* Name: WriteNameButton_Click
* Description: allows user to enter a string only name and saves it to a .txt file
* Input: string
* Output: string to the .txt file
***************************************************************/

        private void WriteNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(nameTextBox.Text, @"^[a-zA-Z]+$"))
                {

                    StreamWriter outputFile;
                    outputFile = File.AppendText("Friend.txt");
                    outputFile.WriteLine(nameTextBox.Text);
                    MessageBox.Show("The name was written.");
                    outputFile.Close();
                    nameTextBox.Text = "";
                    nameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Enter letters only.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**************************************************************
* Name: ExitButton_Click
* Description: closes the application
* Input: n.a
* Output: n.a
***************************************************************/

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**************************************************************
* Name: ReadFileButton_Click
* Description: when clicked the file pulls the friend.txt and reads from start to finish
* Input: string
* Output: list of friends
***************************************************************/

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string friendsName;
                StreamReader inputFile;
                inputFile = File.OpenText("Friend.txt");
                nameListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    friendsName = inputFile.ReadLine();
                    nameListBox.Items.Add(friendsName);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /**************************************************************
* Name: ClearButtonClick
* Description: Clears the listbox
* Input: n.a
* Output: n.a
***************************************************************/

        private void ClearButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
        }
    }
}
