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
* Name        : TipTaxTotalApplicationHale
* Author      : Cody Hale
* Created     : 9/8/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This program overall description here
*               Input:  list and describe
*               Output: list and describe
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace TipTaxTotalHale
{
    public partial class TipTaxTotal : Form
    {
        public TipTaxTotal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /**************************************************************
* Name: calculate Total Button
* Description: Declares the variables, gets the input and then displays the output
* Input: food cost
* Output: tip amount, tax amount and total cost
***************************************************************/

        private void CalculateTotalButton_Click(object sender, EventArgs e)
        {
            decimal food;
            decimal tip;
            decimal tax;
            decimal total;

            // gets the food charge and converts to a string
            food = decimal.Parse(foodCostTextbox.Text);

            // calculates the tip
            tip = food * 0.15m;

            // calculates the tax
            tax = food * 0.07m;

            // calculates the total
            total = food + tip + tax;

            tipTextbox.Text = tip.ToString("c");
            taxTextbox.Text = tax.ToString("c");
            totalCostLabelbox.Text = total.ToString("c");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            /**************************************************************
* Name: close
* Description: sloses the application
***************************************************************/

            this.Close();
        }
        /**************************************************************
* Name: Clear
* Description: Clears the data in the application for new data to be entered
***************************************************************/

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foodCostTextbox.Text = String.Empty;
            tipTextbox.Text = String.Empty;
            taxTextbox.Text = String.Empty;
            totalCostLabelbox.Text = String.Empty;
        }
    }
}
