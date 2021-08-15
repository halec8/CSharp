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
* Description : Gathers a car's year and make then submits it to the CarActionsForm so we can calculate speed based upon the car accelerating or braking.
*               Input:  Car year and make
*               Output: no output
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Car_Class
{
    /***************************************************************
* Name        : CarAcceleration
* Author      : Cody Hale
* Created     : 10/20/2019
***************************************************************/

    public partial class CarAcceleration : Form
    {
        public CarAcceleration()
        {
            InitializeComponent();
        }

        /***************************************************************
* Name        : Car
* Author      : Cody Hale
* Created     : 10/20/2019
***************************************************************/

        class Car
        {
           private int _year;
           private string _make;
           private int _speed;


           /**************************************************************
* Name: Car
* Description: Constructor that accepts year, make and speed
* Input: int year, string make, int speed
***************************************************************/


            public Car(int year, string make, int speed)
           {
               _year = year;
               _make = make;
               _speed = speed;
           }


            /**************************************************************
* Name: Year
* Description: get and set for the year
             *
***************************************************************/

            public int Year
           {
               get { return _year; }
               set { _year = value; }
           }


            /**************************************************************
* Name: Make
* Description: get and set for the make
 *
***************************************************************/

            public string Make
           {
               get { return _make; }
               set { _make = value; }
           }


            /**************************************************************
* Name: speed
* Description: get and set for the speed
 *
***************************************************************/
            public int Speed
           {
               get { return _speed; }
               set { _speed = value; }
           }
        }

        /**************************************************************
* Name: GetCar
* Description: assigns input for year/make/speed to the CarActionsForm

***************************************************************/

        private void GetCar(AccelerateBrake carAccelerateBrake)
        {

            int speed = 0;

            carAccelerateBrake.yearLabel.Text = yearTextBox.Text;

            carAccelerateBrake.makeLabel.Text = makeTextBox.Text;

            carAccelerateBrake.calculatedSpeedLabel.Text = speed.ToString();
        }

        /**************************************************************
* Name: CloseButton_Click
* Description:  closes the program
***************************************************************/


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /**************************************************************
* Name: SubmitButton_Click
* Description: creates an object, calls the GetCarMethod, opens the second form and clears the text boxes.
***************************************************************/


        private void SubmitButton_Click(object sender, EventArgs e)
        {

            AccelerateBrake carAccelerateBrake = new AccelerateBrake();

            GetCar(carAccelerateBrake);

            carAccelerateBrake.ShowDialog();

            yearTextBox.Text = String.Empty;
            makeTextBox.Text = String.Empty;

        }

        private void CarAcceleration_Load(object sender, EventArgs e)
        {

        }
    }
}
