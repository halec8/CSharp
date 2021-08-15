using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***************************************************************
* Name        : Cell Phone Test
* Author      : Cody Hale
* Created     : 10/20/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Gets the brand, model and price of a cellphone and displays what was entered. There is certain criteria that must be fulfilled.
*               Input:  Cellphone brand, model and price
*               Output: Cellphone brand, model and price
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/

namespace Cell_Phone_Test
{


    /***************************************************************
* Name        : CellPhone
* Author      : Cody Hale
* Created     : 10/20/2019
***************************************************************/



    class CellPhone
    {
        // fields
        private string _brand;
        private string _model;
        private decimal _price;

        // constructor

        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;

        }

        // properties
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }

        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }

        }

    }
}
