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
* Name        : WriteSQL Statement
* Author      : Cody Hale
* Created     : 11/1/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Arranges a table of products in various ways based on the button pressed
*         
*               Output: Displays a table of products
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Product_Queries
{
    public partial class ProductDataSet : Form
    {
        public ProductDataSet()
        {
            InitializeComponent();
        }

        private void ProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        // sorts by price ascending
        private void SortByPriceButton_Click(object sender, EventArgs e)
        {

            this.productTableAdapter.FillByPrice(this.productDBDataSet.Product);

        }

        // sorts by units and only displays products with more than 100 units
        private void UnitsGreater100Button_Click(object sender, EventArgs e)
        {

            this.productTableAdapter.FillByUnits(this.productDBDataSet.Product);

        }

        // sorts by products and displays only products that cost more than $40
        private void GreaterThan40DollarsButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByGreaterThan40(this.productDBDataSet.Product);
        }

        // sorts products by greatest price to least price
        private void MostExpensiveProductsButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByPriceDesc(this.productDBDataSet.Product);
        }

        // closes the application
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
