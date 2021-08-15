namespace Student_Structure
{
    partial class StudentStructureProgram
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.displaysInfoListBox = new System.Windows.Forms.ListBox();
            this.nameLabelBox = new System.Windows.Forms.Label();
            this.studentIDLabelBox = new System.Windows.Forms.Label();
            this.majorLabelBox = new System.Windows.Forms.Label();
            this.createStudentButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpMenuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(192, 31);
            this.nameTextBox.TabIndex = 0;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(146, 159);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(192, 31);
            this.studentIDTextBox.TabIndex = 1;
            // 
            // majorTextBox
            // 
            this.majorTextBox.Location = new System.Drawing.Point(146, 263);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(192, 31);
            this.majorTextBox.TabIndex = 2;
            // 
            // displaysInfoListBox
            // 
            this.displaysInfoListBox.FormattingEnabled = true;
            this.displaysInfoListBox.HorizontalScrollbar = true;
            this.displaysInfoListBox.ItemHeight = 25;
            this.displaysInfoListBox.Location = new System.Drawing.Point(373, 40);
            this.displaysInfoListBox.Name = "displaysInfoListBox";
            this.displaysInfoListBox.Size = new System.Drawing.Size(674, 254);
            this.displaysInfoListBox.TabIndex = 3;
            // 
            // nameLabelBox
            // 
            this.nameLabelBox.AutoSize = true;
            this.nameLabelBox.Location = new System.Drawing.Point(12, 62);
            this.nameLabelBox.Name = "nameLabelBox";
            this.nameLabelBox.Size = new System.Drawing.Size(74, 25);
            this.nameLabelBox.TabIndex = 4;
            this.nameLabelBox.Text = "Name:";
            this.nameLabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentIDLabelBox
            // 
            this.studentIDLabelBox.AutoSize = true;
            this.studentIDLabelBox.Location = new System.Drawing.Point(12, 159);
            this.studentIDLabelBox.Name = "studentIDLabelBox";
            this.studentIDLabelBox.Size = new System.Drawing.Size(118, 25);
            this.studentIDLabelBox.TabIndex = 5;
            this.studentIDLabelBox.Text = "Student ID:";
            this.studentIDLabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // majorLabelBox
            // 
            this.majorLabelBox.AutoSize = true;
            this.majorLabelBox.Location = new System.Drawing.Point(14, 263);
            this.majorLabelBox.Name = "majorLabelBox";
            this.majorLabelBox.Size = new System.Drawing.Size(72, 25);
            this.majorLabelBox.TabIndex = 6;
            this.majorLabelBox.Text = "Major:";
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(19, 352);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(220, 42);
            this.createStudentButton.TabIndex = 7;
            this.createStudentButton.Text = "&Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(424, 353);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(200, 41);
            this.displayButton.TabIndex = 8;
            this.displayButton.Text = "&Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(793, 352);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(225, 41);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // helpMenuStrip
            // 
            this.helpMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.helpMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.helpMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.helpMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.helpMenuStrip.Name = "helpMenuStrip";
            this.helpMenuStrip.Size = new System.Drawing.Size(1083, 40);
            this.helpMenuStrip.TabIndex = 10;
            this.helpMenuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // StudentStructureProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 436);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.createStudentButton);
            this.Controls.Add(this.majorLabelBox);
            this.Controls.Add(this.studentIDLabelBox);
            this.Controls.Add(this.nameLabelBox);
            this.Controls.Add(this.displaysInfoListBox);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.helpMenuStrip);
            this.Name = "StudentStructureProgram";
            this.Text = "Student Structure";
            this.Load += new System.EventHandler(this.StudentStructureProgram_Load);
            this.helpMenuStrip.ResumeLayout(false);
            this.helpMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.ListBox displaysInfoListBox;
        private System.Windows.Forms.Label nameLabelBox;
        private System.Windows.Forms.Label studentIDLabelBox;
        private System.Windows.Forms.Label majorLabelBox;
        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip helpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

