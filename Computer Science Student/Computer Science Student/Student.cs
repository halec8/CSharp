using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{

    /***************************************************************
* Name        : Student
* Author      : Cody Hale
* Created     10/27/2019
***************************************************************/

    abstract class Student
    {
        private string _name;
        private string _id;

        /**************************************************************
* Name: Student
* Description: Constructor that accepts field one and field two
* Input: strings
***************************************************************/


        public Student(string name, string id)
        {
            _name = name;
            _id = id;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ID
        {
            get { return _id; }
            set { _name = value; }
        }
        /**************************************************************
* Name: RequiredHours
* Description: gets required hours
***************************************************************/

        public abstract double RequiredHours { get; }
    }
}
