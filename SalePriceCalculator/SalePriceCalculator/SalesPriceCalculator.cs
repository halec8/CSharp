using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : ExceptionHandlingHale
* Author      : Cody Hale
* Created     : 09/05/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  original cost and discount percentage
*               Output: cost after the discount is applied
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/

namespace SalePriceCalculator
{
    public partial class salePriceCalc : Form
    {
        public salePriceCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
           
        {
            /**************************************************************
* Name: try-catch
* Description: allows program syntax to execute, if an 
  exception is provided it catches and displays an error message
***************************************************************/
            try
            {

                /**************************************************************
                * Description: defines variables that will be used in caclulation
                * Input: ioriginal price, discount percentage, total discount and sales price
                * Output: total sales price
                ***************************************************************/

                decimal original; // shows original price
                decimal discountPercentage; // shows the discount percentage
                decimal totalDiscount; // shows the total discount
                decimal salesPrice; // shows the total cost after the discount is applied

                // gets original price and stores it in original
                original = decimal.Parse(originalPricetextbox.Text);
                // gets discount percentage
                discountPercentage = decimal.Parse(discountPercentagetextbox.Text);
                // moves percentage output two decimal places over
                discountPercentage = discountPercentage / 100;
                // calculates origal and discountPerentage to get the total discount
                totalDiscount = original * discountPercentage;
                // finds the sales price by subtracting original and totalDiscount
                salesPrice = original - totalDiscount;
                // shows the total sales price as a string
                salePricelabel.Text = salesPrice.ToString("c");
            }
            catch
            {
                MessageBox.Show("Do not allow strings");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            /**************************************************************
* Name: close
* Description: closes the application
***************************************************************/

            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            /**************************************************************
* Name: clear
* Description: clears data
***************************************************************/

            originalPricetextbox.Text = String.Empty;
            discountPercentagetextbox.Text = String.Empty;
            salePricelabel.Text = String.Empty;

        }
    }
}
