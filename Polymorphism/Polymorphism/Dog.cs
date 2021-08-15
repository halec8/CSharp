using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    /***************************************************************
* Name        : Dog
* Author      : Cody Hale
* Created     : 10/27/2019
***************************************************************/

    class Dog : Animal
    {

        
        private string _name;

        /**************************************************************
* Name: Dog
* Description: Constructor that accepts field one and has a parameter of name
* Input: string name
***************************************************************/

        public Dog(string name)
            : base("Dog")

        {
            _name = name;

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /**************************************************************
* Name: MakeSound
* Description: Displays a message for the animal that is selected
* Output: messagebox with a string
***************************************************************/

        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        }
    }
}
