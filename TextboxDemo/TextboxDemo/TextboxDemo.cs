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
* Name        : TextBoxDemoHale
* Author      : Cody Hale
* Created     : 08/29/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  list and describe
*               Output: list and describe
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace TextboxDemo
{
    public partial class textBoxdemo : Form
    {
        public textBoxdemo()
        {
            InitializeComponent();
        }

        private void ReadUserinputbutton_Click(object sender, EventArgs e)
        {  // translates what the user inputed and displays it within the output
            userOutputtextbox.Text = userInputtextbox.Text;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxdemo_Load(object sender, EventArgs e)
        {

        }
    }
}
