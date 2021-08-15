using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndProductionWorker
{
    /***************************************************************
* Name        : ProductionWorker
* Author      : Cody Hale
* Created     : 10/27/2019
***************************************************************/

    class ProductionWorker : Employee
    {
        private int _shift;
        private decimal _hourlyRate;


        /**************************************************************
* Name: ProductionWorker
* Description: Constructor that accepts field one and field two
* Input: int field1, decimal field2
***************************************************************/

        public ProductionWorker()
        {
            _shift = 0;
            _hourlyRate = 0;
        }

        public int Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        public decimal HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }
    }
}
