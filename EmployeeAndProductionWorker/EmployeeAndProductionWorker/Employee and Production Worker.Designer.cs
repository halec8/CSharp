namespace EmployeeAndProductionWorker
{
    partial class EmployeeAndProductionWorker
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
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.empNumberPromptLabel = new System.Windows.Forms.Label();
            this.hourlyRatePromptLabel = new System.Windows.Forms.Label();
            this.shiftPromptGroupbox = new System.Windows.Forms.GroupBox();
            this.secondShiftRadioButton = new System.Windows.Forms.RadioButton();
            this.firstShiftRadiobutton = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumTextbox = new System.Windows.Forms.TextBox();
            this.hourlyRateTextbox = new System.Windows.Forms.TextBox();
            this.nameDisplayedLabel = new System.Windows.Forms.Label();
            this.employeeNumDisplayedLabel = new System.Windows.Forms.Label();
            this.hourlyRateDisplayedLabel = new System.Windows.Forms.Label();
            this.shiftWorkedDisplayedLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayedNameLabel = new System.Windows.Forms.Label();
            this.displayedEmployeeNumLabel = new System.Windows.Forms.Label();
            this.displayedHourlyRate = new System.Windows.Forms.Label();
            this.displayedShiftWorked = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.shiftPromptGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.AutoSize = true;
            this.namePromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.namePromptLabel.Location = new System.Drawing.Point(40, 38);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(76, 27);
            this.namePromptLabel.TabIndex = 0;
            this.namePromptLabel.Text = "Name:";
            this.namePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empNumberPromptLabel
            // 
            this.empNumberPromptLabel.AutoSize = true;
            this.empNumberPromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empNumberPromptLabel.Location = new System.Drawing.Point(40, 99);
            this.empNumberPromptLabel.Name = "empNumberPromptLabel";
            this.empNumberPromptLabel.Size = new System.Drawing.Size(196, 27);
            this.empNumberPromptLabel.TabIndex = 1;
            this.empNumberPromptLabel.Text = "Employee Number:";
            this.empNumberPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourlyRatePromptLabel
            // 
            this.hourlyRatePromptLabel.AutoSize = true;
            this.hourlyRatePromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hourlyRatePromptLabel.Location = new System.Drawing.Point(40, 166);
            this.hourlyRatePromptLabel.Name = "hourlyRatePromptLabel";
            this.hourlyRatePromptLabel.Size = new System.Drawing.Size(133, 27);
            this.hourlyRatePromptLabel.TabIndex = 3;
            this.hourlyRatePromptLabel.Text = "Hourly Rate:";
            this.hourlyRatePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shiftPromptGroupbox
            // 
            this.shiftPromptGroupbox.Controls.Add(this.secondShiftRadioButton);
            this.shiftPromptGroupbox.Controls.Add(this.firstShiftRadiobutton);
            this.shiftPromptGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shiftPromptGroupbox.Location = new System.Drawing.Point(110, 241);
            this.shiftPromptGroupbox.Name = "shiftPromptGroupbox";
            this.shiftPromptGroupbox.Size = new System.Drawing.Size(242, 168);
            this.shiftPromptGroupbox.TabIndex = 4;
            this.shiftPromptGroupbox.TabStop = false;
            this.shiftPromptGroupbox.Text = "Shift Worked:";
            // 
            // secondShiftRadioButton
            // 
            this.secondShiftRadioButton.AutoSize = true;
            this.secondShiftRadioButton.Location = new System.Drawing.Point(51, 110);
            this.secondShiftRadioButton.Name = "secondShiftRadioButton";
            this.secondShiftRadioButton.Size = new System.Drawing.Size(165, 29);
            this.secondShiftRadioButton.TabIndex = 1;
            this.secondShiftRadioButton.TabStop = true;
            this.secondShiftRadioButton.Text = "Second Shift";
            this.secondShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstShiftRadiobutton
            // 
            this.firstShiftRadiobutton.AutoSize = true;
            this.firstShiftRadiobutton.Location = new System.Drawing.Point(51, 49);
            this.firstShiftRadiobutton.Name = "firstShiftRadiobutton";
            this.firstShiftRadiobutton.Size = new System.Drawing.Size(134, 29);
            this.firstShiftRadiobutton.TabIndex = 0;
            this.firstShiftRadiobutton.TabStop = true;
            this.firstShiftRadiobutton.Text = "First Shift";
            this.firstShiftRadiobutton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(261, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(184, 31);
            this.nameTextBox.TabIndex = 5;
            // 
            // employeeNumTextbox
            // 
            this.employeeNumTextbox.Location = new System.Drawing.Point(260, 93);
            this.employeeNumTextbox.Name = "employeeNumTextbox";
            this.employeeNumTextbox.Size = new System.Drawing.Size(184, 31);
            this.employeeNumTextbox.TabIndex = 6;
            // 
            // hourlyRateTextbox
            // 
            this.hourlyRateTextbox.Location = new System.Drawing.Point(260, 160);
            this.hourlyRateTextbox.Name = "hourlyRateTextbox";
            this.hourlyRateTextbox.Size = new System.Drawing.Size(184, 31);
            this.hourlyRateTextbox.TabIndex = 7;
            // 
            // nameDisplayedLabel
            // 
            this.nameDisplayedLabel.AutoSize = true;
            this.nameDisplayedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameDisplayedLabel.Location = new System.Drawing.Point(45, 454);
            this.nameDisplayedLabel.Name = "nameDisplayedLabel";
            this.nameDisplayedLabel.Size = new System.Drawing.Size(76, 27);
            this.nameDisplayedLabel.TabIndex = 8;
            this.nameDisplayedLabel.Text = "Name:";
            this.nameDisplayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeNumDisplayedLabel
            // 
            this.employeeNumDisplayedLabel.AutoSize = true;
            this.employeeNumDisplayedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeNumDisplayedLabel.Location = new System.Drawing.Point(40, 510);
            this.employeeNumDisplayedLabel.Name = "employeeNumDisplayedLabel";
            this.employeeNumDisplayedLabel.Size = new System.Drawing.Size(196, 27);
            this.employeeNumDisplayedLabel.TabIndex = 9;
            this.employeeNumDisplayedLabel.Text = "Employee Number:";
            this.employeeNumDisplayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourlyRateDisplayedLabel
            // 
            this.hourlyRateDisplayedLabel.AutoSize = true;
            this.hourlyRateDisplayedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hourlyRateDisplayedLabel.Location = new System.Drawing.Point(40, 565);
            this.hourlyRateDisplayedLabel.Name = "hourlyRateDisplayedLabel";
            this.hourlyRateDisplayedLabel.Size = new System.Drawing.Size(133, 27);
            this.hourlyRateDisplayedLabel.TabIndex = 10;
            this.hourlyRateDisplayedLabel.Text = "Hourly Rate:";
            this.hourlyRateDisplayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shiftWorkedDisplayedLabel
            // 
            this.shiftWorkedDisplayedLabel.AutoSize = true;
            this.shiftWorkedDisplayedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shiftWorkedDisplayedLabel.Location = new System.Drawing.Point(40, 622);
            this.shiftWorkedDisplayedLabel.Name = "shiftWorkedDisplayedLabel";
            this.shiftWorkedDisplayedLabel.Size = new System.Drawing.Size(149, 27);
            this.shiftWorkedDisplayedLabel.TabIndex = 11;
            this.shiftWorkedDisplayedLabel.Text = "Shift Worked: ";
            this.shiftWorkedDisplayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(161, 690);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(123, 59);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(310, 690);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 59);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // displayedNameLabel
            // 
            this.displayedNameLabel.AutoSize = true;
            this.displayedNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayedNameLabel.Location = new System.Drawing.Point(256, 454);
            this.displayedNameLabel.Name = "displayedNameLabel";
            this.displayedNameLabel.Size = new System.Drawing.Size(2, 27);
            this.displayedNameLabel.TabIndex = 14;
            this.displayedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayedEmployeeNumLabel
            // 
            this.displayedEmployeeNumLabel.AutoSize = true;
            this.displayedEmployeeNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayedEmployeeNumLabel.Location = new System.Drawing.Point(256, 510);
            this.displayedEmployeeNumLabel.Name = "displayedEmployeeNumLabel";
            this.displayedEmployeeNumLabel.Size = new System.Drawing.Size(2, 27);
            this.displayedEmployeeNumLabel.TabIndex = 15;
            this.displayedEmployeeNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayedHourlyRate
            // 
            this.displayedHourlyRate.AutoSize = true;
            this.displayedHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayedHourlyRate.Location = new System.Drawing.Point(256, 567);
            this.displayedHourlyRate.Name = "displayedHourlyRate";
            this.displayedHourlyRate.Size = new System.Drawing.Size(2, 27);
            this.displayedHourlyRate.TabIndex = 16;
            this.displayedHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayedShiftWorked
            // 
            this.displayedShiftWorked.AutoSize = true;
            this.displayedShiftWorked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayedShiftWorked.Location = new System.Drawing.Point(256, 624);
            this.displayedShiftWorked.Name = "displayedShiftWorked";
            this.displayedShiftWorked.Size = new System.Drawing.Size(2, 27);
            this.displayedShiftWorked.TabIndex = 17;
            this.displayedShiftWorked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 690);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(120, 59);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EmployeeAndProductionWorker
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(462, 791);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.displayedShiftWorked);
            this.Controls.Add(this.displayedHourlyRate);
            this.Controls.Add(this.displayedEmployeeNumLabel);
            this.Controls.Add(this.displayedNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.shiftWorkedDisplayedLabel);
            this.Controls.Add(this.hourlyRateDisplayedLabel);
            this.Controls.Add(this.employeeNumDisplayedLabel);
            this.Controls.Add(this.nameDisplayedLabel);
            this.Controls.Add(this.hourlyRateTextbox);
            this.Controls.Add(this.employeeNumTextbox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.shiftPromptGroupbox);
            this.Controls.Add(this.hourlyRatePromptLabel);
            this.Controls.Add(this.empNumberPromptLabel);
            this.Controls.Add(this.namePromptLabel);
            this.Name = "EmployeeAndProductionWorker";
            this.Text = "Employee and Production Worker";
            this.shiftPromptGroupbox.ResumeLayout(false);
            this.shiftPromptGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namePromptLabel;
        private System.Windows.Forms.Label empNumberPromptLabel;
        private System.Windows.Forms.Label hourlyRatePromptLabel;
        private System.Windows.Forms.GroupBox shiftPromptGroupbox;
        private System.Windows.Forms.RadioButton secondShiftRadioButton;
        private System.Windows.Forms.RadioButton firstShiftRadiobutton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox employeeNumTextbox;
        private System.Windows.Forms.TextBox hourlyRateTextbox;
        private System.Windows.Forms.Label nameDisplayedLabel;
        private System.Windows.Forms.Label employeeNumDisplayedLabel;
        private System.Windows.Forms.Label hourlyRateDisplayedLabel;
        private System.Windows.Forms.Label shiftWorkedDisplayedLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label displayedNameLabel;
        private System.Windows.Forms.Label displayedEmployeeNumLabel;
        private System.Windows.Forms.Label displayedHourlyRate;
        private System.Windows.Forms.Label displayedShiftWorked;
        private System.Windows.Forms.Button submitButton;
    }
}

