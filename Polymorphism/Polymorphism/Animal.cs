using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{

    /***************************************************************
* Name        : Animal
* Author      : Cody Hale
* Created     : 10/27/2019
***************************************************************/

    class Animal
    {
        private string _species;

        /**************************************************************
* Name: Animal
* Description: Constructor that accepts field one and has a parameter species
* Input: string species
***************************************************************/

        public Animal(string species)
        {
            _species = species;
        }

        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        /**************************************************************
* Name: MakeSound
* Description: Displays a message for the animal that is selected
* Output: messagebox with a string
***************************************************************/

        public virtual void MakeSound()


        {
            MessageBox.Show("Grrrrrrr");
        }
    }
}
