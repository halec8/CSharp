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
* Name        : Employee Searching
* Author      : Cody Hale
* Created     : 11/3/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Allows the user to search a database for specific information
*               Input: Search criteria 
*               Output: Information pertaining to the search criteria
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Employee_Searching

/***************************************************************
* Name        : Form1
* Author      : Cody Hale
* Created     : 11/3/2019
***************************************************************/

{
    public partial class EmployeeSearch : Form
    {
        public EmployeeSearch()
        {
            InitializeComponent();
        }

        /**************************************************************
* Name: employee_Data_TableBindingNavigatorSaveItem_Click
* Description: saves the table and allows the user to edit/update the database
***************************************************************/

        private void employee_Data_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_Data_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee_Data_Table' table. You can move, or remove it, as needed.
            this.employee_Data_TableTableAdapter.Fill(this.personnelDataSet.Employee_Data_Table);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /**************************************************************
* Name: SearchButton_Click
* Description: Allows the user to search the database for specific search criteria then displays the criteria in the gridview
***************************************************************/

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.employee_Data_TableTableAdapter.SearchDesc(this.personnelDataSet.Employee_Data_Table,
                searchTextBox.Text);
        }

        /**************************************************************
* Name: showAllButton_Click
* Description: Shows all fields in the database through the gridview
***************************************************************/

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.employee_Data_TableTableAdapter.Fill(this.personnelDataSet.Employee_Data_Table);
        }

        // Closes the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
