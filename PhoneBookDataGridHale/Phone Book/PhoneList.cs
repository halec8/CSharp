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
* Name        : Phone Book Data Grid
* Author      : Cody Hale
* Created     : 11/1/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Displays names and phone numbers
*               Input: Can input names and phone numbers to update the database 
*               Output: Displays a database of names and phone numbers
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace Phone_Book
{
    public partial class PhoneList : Form
    {
        public PhoneList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.personDataSet.Table);

        }

        private void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personDataSet);

        }
    }
}
