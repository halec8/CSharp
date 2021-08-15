using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{

    /***************************************************************
* Name        : CompSciStudent
* Author      : Cody Hale
* Created     : 10/27/2019
***************************************************************/

    class CompSciStudent : Student
    {
        private const double MATH_HRS = 20;
        private const double CS_HRS = 40;
        private const double GEN_HRS = 60;

        private string _academicTrack;

        /**************************************************************
* Name: CompSciStudent
* Description: Constructor that accepts field one and  multiple parameters/base parameters
* Input: strings
***************************************************************/

        public CompSciStudent(string name, string id, string track) : base(name, id)

        {
            _academicTrack = track;
        }

        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }

        /**************************************************************
* Name: RequiredHours
* Description: displays required credit houts
* Output: Required credit hours
***************************************************************/

        public override double RequiredHours
        {
            get { return MATH_HRS + CS_HRS + GEN_HRS; }
        }
    }
}
