using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndProductionWorker
{

    /***************************************************************
* Name        : Employee
* Author      : Cody Hale
* Created     : 10/27/2019
***************************************************************/

    class Employee
    {
        private string _name;
        private int _employeeNumber;

        /**************************************************************
* Name: Employee
* Description: Constructor that accepts field one and field two
* Input: string field1, int field2
***************************************************************/


        public Employee()
        {
            _name = "";
            _employeeNumber = 0;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int EmployeeNumber
        {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }
    }
}
