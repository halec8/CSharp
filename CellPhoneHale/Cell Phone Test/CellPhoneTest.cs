using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


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
* Name        : CellPhoneTest
* Author      : Cody Hale
* Created     : 10/20/2019
***************************************************************/



    public partial class CellPhoneTest : Form
    {
        public CellPhoneTest()
        {
            InitializeComponent();
        }

        /**************************************************************
* Name: GetPhoneData
* Description: Gets the phone data from the user, if certain criteria isn't met an error message will display.
* Input: string, string, decimal
***************************************************************/

        private void GetPhoneData(CellPhone phone)
        {


            try
            {
                decimal price;
                if (brandTextBox.Text == "Samsung" && modelTextBox.Text == "Galaxy" || brandTextBox.Text == "Samsung" &&
                    modelTextBox.Text == "Note" || brandTextBox.Text == "iPhone" && modelTextBox.Text == "X"|| brandTextBox.Text == "Google")
                {
                    phone.Brand = brandTextBox.Text;
                }

                else
                {
                    MessageBox.Show("Invalid brand");
                }

                phone.Model = modelTextBox.Text;

                if (decimal.TryParse(priceTextBox.Text, out price))

                    if (price <= 2000 && price > 0)
                    {
                        phone.Price = price;

                    }
                    else
                    {
                        MessageBox.Show("Invalid Price");
                    }
            }

            catch

                (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /**************************************************************
* Name: CreateObjectButton
* Description: Pulls the information that was entered by the user and creates and object that is displayed.
* Output: string, string, decimal
***************************************************************/


        private void CreateObjectButton_Click(object sender, EventArgs e)
        {

            try
            {
                CellPhone myPhone = new CellPhone();

            GetPhoneData(myPhone);

            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }

        /**************************************************************
* Name: ExitButton_Click
* Description: Closes the program
***************************************************************/

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
