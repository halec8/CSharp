using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{

    /***************************************************************
* Name        : Cat
* Author      : Cody Hale
* Created     : 10/27/2019
***************************************************************/

    class Cat : Animal
    {
        private string _name;

        /**************************************************************
* Name: Cat
* Description: Constructor that accepts field one and has a parameter name
* Input: string name
***************************************************************/

        public Cat(string name)
            : base("Cat")
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
            MessageBox.Show("Meow");
        }
    }
}
