namespace Employee_Searching
{
    partial class EmployeeSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSearch));
            this.employee_Data_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.employee_Data_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelDataSet = new Employee_Searching.PersonnelDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employee_Data_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employee_Data_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.employee_Data_TableTableAdapter = new Employee_Searching.PersonnelDataSetTableAdapters.Employee_Data_TableTableAdapter();
            this.tableAdapterManager = new Employee_Searching.PersonnelDataSetTableAdapters.TableAdapterManager();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Data_TableBindingNavigator)).BeginInit();
            this.employee_Data_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Data_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Data_TableDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee_Data_TableBindingNavigator
            // 
            this.employee_Data_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employee_Data_TableBindingNavigator.BindingSource = this.employee_Data_TableBindingSource;
            this.employee_Data_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employee_Data_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employee_Data_TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.employee_Data_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employee_Data_TableBindingNavigatorSaveItem});
            this.employee_Data_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employee_Data_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employee_Data_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employee_Data_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employee_Data_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employee_Data_TableBindingNavigator.Name = "employee_Data_TableBindingNavigator";
            this.employee_Data_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employee_Data_TableBindingNavigator.Size = new System.Drawing.Size(1162, 50);
            this.employee_Data_TableBindingNavigator.TabIndex = 0;
            this.employee_Data_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // employee_Data_TableBindingSource
            // 
            this.employee_Data_TableBindingSource.DataMember = "Employee Data Table";
            this.employee_Data_TableBindingSource.DataSource = this.personnelDataSet;
            // 
            // personnelDataSet
            // 
            this.personnelDataSet.DataSetName = "PersonnelDataSet";
            this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // employee_Data_TableBindingNavigatorSaveItem
            // 
            this.employee_Data_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employee_Data_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employee_Data_TableBindingNavigatorSaveItem.Image")));
            this.employee_Data_TableBindingNavigatorSaveItem.Name = "employee_Data_TableBindingNavigatorSaveItem";
            this.employee_Data_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.employee_Data_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.employee_Data_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.employee_Data_TableBindingNavigatorSaveItem_Click);
            // 
            // employee_Data_TableDataGridView
            // 
            this.employee_Data_TableDataGridView.AutoGenerateColumns = false;
            this.employee_Data_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_Data_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.employee_Data_TableDataGridView.DataSource = this.employee_Data_TableBindingSource;
            this.employee_Data_TableDataGridView.Location = new System.Drawing.Point(149, 92);
            this.employee_Data_TableDataGridView.Name = "employee_Data_TableDataGridView";
            this.employee_Data_TableDataGridView.RowHeadersWidth = 82;
            this.employee_Data_TableDataGridView.RowTemplate.Height = 33;
            this.employee_Data_TableDataGridView.Size = new System.Drawing.Size(884, 268);
            this.employee_Data_TableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Employee ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn3.HeaderText = "Position";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pay Rate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pay Rate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(208, 455);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(337, 170);
            this.searchGroupBox.TabIndex = 2;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Criteria";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(100, 95);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 45);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(36, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(230, 31);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(585, 492);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(167, 103);
            this.showAllButton.TabIndex = 3;
            this.showAllButton.Text = "S&how All Items";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // employee_Data_TableTableAdapter
            // 
            this.employee_Data_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Employee_Data_TableTableAdapter = this.employee_Data_TableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Employee_Searching.PersonnelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(794, 492);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 102);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // EmployeeSearch
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1162, 661);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.employee_Data_TableDataGridView);
            this.Controls.Add(this.employee_Data_TableBindingNavigator);
            this.Name = "EmployeeSearch";
            this.Text = "Employee Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_Data_TableBindingNavigator)).EndInit();
            this.employee_Data_TableBindingNavigator.ResumeLayout(false);
            this.employee_Data_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Data_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Data_TableDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonnelDataSet personnelDataSet;
        private System.Windows.Forms.BindingSource employee_Data_TableBindingSource;
        private PersonnelDataSetTableAdapters.Employee_Data_TableTableAdapter employee_Data_TableTableAdapter;
        private PersonnelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employee_Data_TableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employee_Data_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView employee_Data_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button exitButton;
    }
}

