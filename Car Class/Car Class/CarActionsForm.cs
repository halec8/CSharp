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
* Name        : Car Class
* Author      : Cody Hale
* Created     : 10/20/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  no input
*               Output: Displays the year and make of the vehicle and calculates the speed if accelerating or braking.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/

namespace Car_Class
{

    /***************************************************************
* Name        : AccelerateBrake
* Author      : Cody Hale
* Created     : 10/20/2019
***************************************************************/

    public partial class AccelerateBrake : Form
    {
        public AccelerateBrake()
        {
            InitializeComponent();
        }


        /**************************************************************
* Name: Close
* Description: closes the form

***************************************************************/

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /**************************************************************
* Name: AccelerateButton_Click
* Description: Increases speed by 5
* Output: Current speed + 5
***************************************************************/

        private void AccelerateButton_Click(object sender, EventArgs e)
        {
            int speed = 0;

            if(int.TryParse(calculatedSpeedLabel.Text, out speed))
            {
                if (speed < 90)
                {
                    speed += 5;
                    calculatedSpeedLabel.Text = speed.ToString();
                }
                else
                {
                    MessageBox.Show("Your going to fast, slow it down! No speeding allowed!");
                }
            }
        }

        /**************************************************************
* Name: BreakButton_Click
* Description: Decreases speed by 5
* Output: Current speed - 5
***************************************************************/

        private void BrakeButton_Click(object sender, EventArgs e)
        {
            int speed;

            if (int.TryParse(calculatedSpeedLabel.Text, out speed))
            {
                if (speed > 0)
                {
                    speed -= 5;
                    calculatedSpeedLabel.Text = speed.ToString();
                }
                else
                {
                    MessageBox.Show("You can't go any slower, try accelerating!");
                }
            }
        }
    }
}
