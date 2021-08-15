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
* Name        : PictureFrame
* Author      : FirstName LastName
* Created     : 10/11/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  
*               Output: random photos
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace PictureFrame
{

    /***************************************************************
* Name        : PictureFrame
* Author      : Cody Hale
* Created     : 10.11.2019
***************************************************************/

    public partial class PictureFrame : Form
    {
        public PictureFrame()
        {
            InitializeComponent();
        }


        /**************************************************************
* Name: PictureFramePictureBox_Click
* Description: picturebox that displays a random image when clicked
* Output: displays random image from the imageList
***************************************************************/

        private void PicFramePictureBox_Click(object sender, EventArgs e)
        {
            Random picture = new Random();


            int index = picture.Next(photoList.Images.Count);

            picFramePictureBox.Image = photoList.Images[index];

        }

        /**************************************************************
* Name: PictureFrame_Load
* Description: displays a message box that tells the user how the program functions
* Output: string
***************************************************************/

        private void PictureFrame_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Click inside the frame to see the next picture.");

        }

        /**************************************************************
* Name: HelpToolStripMenuItem_Click
* Description: clears the picture box
***************************************************************/

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picFramePictureBox.Image = null;

        }

        /**************************************************************
* Name: ExitToolStripMenuItem_Click
* Description: closes the program
***************************************************************/

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**************************************************************
* Name: HelpToolStripMenuItem1_Click
* Description: shows who created the program and how it operates
* Output: string
***************************************************************/

        private void HelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Cody Hale on 10.11.2019");

            MessageBox.Show("Click inside the frame to see the next picture!");
        }

        /**************************************************************
* Name: ExitButton_Click
* Description: closes the program
***************************************************************/

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**************************************************************
* Name: ClearButton_Click
* Description: clears the picture box
***************************************************************/

        private void ClearButton_Click(object sender, EventArgs e)
        {
            picFramePictureBox.Image = null;
        }
    }
}
