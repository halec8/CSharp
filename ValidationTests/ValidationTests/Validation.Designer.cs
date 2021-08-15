namespace ValidationTests
{
    partial class Validation
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
            this.studentIDPromptLabel = new System.Windows.Forms.Label();
            this.studentFirstNamePromptLabel = new System.Windows.Forms.Label();
            this.studentLastNamePromptLabel = new System.Windows.Forms.Label();
            this.classCRNPromptLabel = new System.Windows.Forms.Label();
            this.classCodeAndNumberPromptLabel = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.classCRNTextBox = new System.Windows.Forms.TextBox();
            this.classCodeAndNumberTextBox = new System.Windows.Forms.TextBox();
            this.validationListBox = new System.Windows.Forms.ListBox();
            this.validateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.validatedGroupBox = new System.Windows.Forms.GroupBox();
            this.validatedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIDPromptLabel
            // 
            this.studentIDPromptLabel.AutoSize = true;
            this.studentIDPromptLabel.Location = new System.Drawing.Point(64, 69);
            this.studentIDPromptLabel.Name = "studentIDPromptLabel";
            this.studentIDPromptLabel.Size = new System.Drawing.Size(175, 25);
            this.studentIDPromptLabel.TabIndex = 0;
            this.studentIDPromptLabel.Text = "Enter Student ID:";
            // 
            // studentFirstNamePromptLabel
            // 
            this.studentFirstNamePromptLabel.AutoSize = true;
            this.studentFirstNamePromptLabel.Location = new System.Drawing.Point(64, 135);
            this.studentFirstNamePromptLabel.Name = "studentFirstNamePromptLabel";
            this.studentFirstNamePromptLabel.Size = new System.Drawing.Size(270, 25);
            this.studentFirstNamePromptLabel.TabIndex = 1;
            this.studentFirstNamePromptLabel.Text = "Enter Students First Name:";
            // 
            // studentLastNamePromptLabel
            // 
            this.studentLastNamePromptLabel.AutoSize = true;
            this.studentLastNamePromptLabel.Location = new System.Drawing.Point(64, 218);
            this.studentLastNamePromptLabel.Name = "studentLastNamePromptLabel";
            this.studentLastNamePromptLabel.Size = new System.Drawing.Size(269, 25);
            this.studentLastNamePromptLabel.TabIndex = 2;
            this.studentLastNamePromptLabel.Text = "Enter Students Last Name:";
            // 
            // classCRNPromptLabel
            // 
            this.classCRNPromptLabel.AutoSize = true;
            this.classCRNPromptLabel.Location = new System.Drawing.Point(64, 294);
            this.classCRNPromptLabel.Name = "classCRNPromptLabel";
            this.classCRNPromptLabel.Size = new System.Drawing.Size(348, 25);
            this.classCRNPromptLabel.TabIndex = 3;
            this.classCRNPromptLabel.Text = "Enter Your Classes CRN Numnber:";
            // 
            // classCodeAndNumberPromptLabel
            // 
            this.classCodeAndNumberPromptLabel.AutoSize = true;
            this.classCodeAndNumberPromptLabel.Location = new System.Drawing.Point(64, 369);
            this.classCodeAndNumberPromptLabel.Name = "classCodeAndNumberPromptLabel";
            this.classCodeAndNumberPromptLabel.Size = new System.Drawing.Size(319, 25);
            this.classCodeAndNumberPromptLabel.TabIndex = 4;
            this.classCodeAndNumberPromptLabel.Text = "Enter Your Class Code/Number:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(461, 69);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(300, 31);
            this.studentIDTextBox.TabIndex = 5;
            // 
            // studentFirstNameTextBox
            // 
            this.studentFirstNameTextBox.Location = new System.Drawing.Point(461, 144);
            this.studentFirstNameTextBox.Name = "studentFirstNameTextBox";
            this.studentFirstNameTextBox.Size = new System.Drawing.Size(300, 31);
            this.studentFirstNameTextBox.TabIndex = 6;
            // 
            // studentLastNameTextBox
            // 
            this.studentLastNameTextBox.Location = new System.Drawing.Point(461, 218);
            this.studentLastNameTextBox.Name = "studentLastNameTextBox";
            this.studentLastNameTextBox.Size = new System.Drawing.Size(300, 31);
            this.studentLastNameTextBox.TabIndex = 7;
            // 
            // classCRNTextBox
            // 
            this.classCRNTextBox.Location = new System.Drawing.Point(461, 288);
            this.classCRNTextBox.Name = "classCRNTextBox";
            this.classCRNTextBox.Size = new System.Drawing.Size(300, 31);
            this.classCRNTextBox.TabIndex = 8;
            // 
            // classCodeAndNumberTextBox
            // 
            this.classCodeAndNumberTextBox.Location = new System.Drawing.Point(461, 363);
            this.classCodeAndNumberTextBox.Name = "classCodeAndNumberTextBox";
            this.classCodeAndNumberTextBox.Size = new System.Drawing.Size(300, 31);
            this.classCodeAndNumberTextBox.TabIndex = 9;
            // 
            // validationListBox
            // 
            this.validationListBox.FormattingEnabled = true;
            this.validationListBox.ItemHeight = 25;
            this.validationListBox.Location = new System.Drawing.Point(73, 30);
            this.validationListBox.Name = "validationListBox";
            this.validationListBox.Size = new System.Drawing.Size(555, 279);
            this.validationListBox.TabIndex = 10;
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(891, 78);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(227, 107);
            this.validateButton.TabIndex = 11;
            this.validateButton.Text = "&Validate";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(891, 304);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(227, 107);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(891, 535);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(227, 107);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // validatedGroupBox
            // 
            this.validatedGroupBox.Controls.Add(this.validationListBox);
            this.validatedGroupBox.Location = new System.Drawing.Point(69, 409);
            this.validatedGroupBox.Name = "validatedGroupBox";
            this.validatedGroupBox.Size = new System.Drawing.Size(676, 329);
            this.validatedGroupBox.TabIndex = 14;
            this.validatedGroupBox.TabStop = false;
            this.validatedGroupBox.Text = "Validated Input";
            // 
            // Validation
            // 
            this.AcceptButton = this.validateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1257, 792);
            this.Controls.Add(this.validatedGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.classCodeAndNumberTextBox);
            this.Controls.Add(this.classCRNTextBox);
            this.Controls.Add(this.studentLastNameTextBox);
            this.Controls.Add(this.studentFirstNameTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.classCodeAndNumberPromptLabel);
            this.Controls.Add(this.classCRNPromptLabel);
            this.Controls.Add(this.studentLastNamePromptLabel);
            this.Controls.Add(this.studentFirstNamePromptLabel);
            this.Controls.Add(this.studentIDPromptLabel);
            this.Name = "Validation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Validation";
            this.validatedGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDPromptLabel;
        private System.Windows.Forms.Label studentFirstNamePromptLabel;
        private System.Windows.Forms.Label studentLastNamePromptLabel;
        private System.Windows.Forms.Label classCRNPromptLabel;
        private System.Windows.Forms.Label classCodeAndNumberPromptLabel;
        public System.Windows.Forms.TextBox studentIDTextBox;
        public System.Windows.Forms.TextBox studentFirstNameTextBox;
        public System.Windows.Forms.TextBox studentLastNameTextBox;
        public System.Windows.Forms.TextBox classCRNTextBox;
        public System.Windows.Forms.TextBox classCodeAndNumberTextBox;
        public System.Windows.Forms.ListBox validationListBox;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox validatedGroupBox;
    }
}

