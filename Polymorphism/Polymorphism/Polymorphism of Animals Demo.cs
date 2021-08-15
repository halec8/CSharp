using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/***************************************************************
* Name        : Polymorphism
* Author      : Cody Hale
* Created     : 10/27/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Select a button and display their info and the noise they make
*               Input:  select a button to click
*               Output: animal information/sound they make
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Polymorphism
{
    public partial class PolymorphismDemo : Form
    {
        public PolymorphismDemo()
        {
            InitializeComponent();
        }

        /**************************************************************
* Name: ShowAnimalInfo
* Description: Displays the info for the animal
* Output: messagebox with a string
***************************************************************/

        private void ShowAnimalInfo(Animal animal)

        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        /**************************************************************
* Name: Form1_Load
* Description: Displays a message to the user to prompt them to make a selection
* Output: messagebox with a string
***************************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Click a button, any button!");
        }

        /**************************************************************
* Name: CreateAnimalButton_Click
* Description: Creates objects called Animal
* Output: messagebox with a string
***************************************************************/

        private void CreateAnimalButton_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("Regular Animal");
            ShowAnimalInfo(myAnimal);
        }


        /**************************************************************
* Name: CreateDogButton_Click
* Description: Creates an dog object and displays info/sound
* Output: messagebox with a string
***************************************************************/
        private void CreateDogButton_Click(object sender, EventArgs e)

        {
            Dog myDog = new Dog("Fido");
            MessageBox.Show("The dog's name is " + myDog.Name);
            ShowAnimalInfo(myDog);
        }

        /**************************************************************
* Name: CreateCatButton_Click
* Description: Creates a cat object and displays info/sound
* Output: messagebox with a string
***************************************************************/
        private void CreateCatButton_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Kitty");
            MessageBox.Show("The cat's name is " + myCat.Name);
            ShowAnimalInfo(myCat);
        }

        // closes the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
