namespace TimeCalculator
{
    partial class timeCalculator
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.resultsGroupbox = new System.Windows.Forms.GroupBox();
            this.secondsDisplayLabel = new System.Windows.Forms.Label();
            this.minutesDisplayLabel = new System.Windows.Forms.Label();
            this.hoursDisplayLabel = new System.Windows.Forms.Label();
            this.daysDisplayLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(57, 32);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(159, 25);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter Seconds:";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(239, 32);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(140, 31);
            this.secondsTextBox.TabIndex = 1;
            // 
            // resultsGroupbox
            // 
            this.resultsGroupbox.Controls.Add(this.secondsDisplayLabel);
            this.resultsGroupbox.Controls.Add(this.minutesDisplayLabel);
            this.resultsGroupbox.Controls.Add(this.hoursDisplayLabel);
            this.resultsGroupbox.Controls.Add(this.daysDisplayLabel);
            this.resultsGroupbox.Controls.Add(this.secondsLabel);
            this.resultsGroupbox.Controls.Add(this.minutesLabel);
            this.resultsGroupbox.Controls.Add(this.hoursLabel);
            this.resultsGroupbox.Controls.Add(this.daysLabel);
            this.resultsGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resultsGroupbox.Location = new System.Drawing.Point(24, 103);
            this.resultsGroupbox.Name = "resultsGroupbox";
            this.resultsGroupbox.Size = new System.Drawing.Size(439, 270);
            this.resultsGroupbox.TabIndex = 2;
            this.resultsGroupbox.TabStop = false;
            this.resultsGroupbox.Text = "Results";
            // 
            // secondsDisplayLabel
            // 
            this.secondsDisplayLabel.AutoSize = true;
            this.secondsDisplayLabel.Location = new System.Drawing.Point(177, 213);
            this.secondsDisplayLabel.Name = "secondsDisplayLabel";
            this.secondsDisplayLabel.Size = new System.Drawing.Size(0, 25);
            this.secondsDisplayLabel.TabIndex = 7;
            // 
            // minutesDisplayLabel
            // 
            this.minutesDisplayLabel.AutoSize = true;
            this.minutesDisplayLabel.Location = new System.Drawing.Point(177, 159);
            this.minutesDisplayLabel.Name = "minutesDisplayLabel";
            this.minutesDisplayLabel.Size = new System.Drawing.Size(0, 25);
            this.minutesDisplayLabel.TabIndex = 6;
            // 
            // hoursDisplayLabel
            // 
            this.hoursDisplayLabel.AutoSize = true;
            this.hoursDisplayLabel.Location = new System.Drawing.Point(177, 109);
            this.hoursDisplayLabel.Name = "hoursDisplayLabel";
            this.hoursDisplayLabel.Size = new System.Drawing.Size(0, 25);
            this.hoursDisplayLabel.TabIndex = 5;
            // 
            // daysDisplayLabel
            // 
            this.daysDisplayLabel.AutoSize = true;
            this.daysDisplayLabel.Location = new System.Drawing.Point(177, 55);
            this.daysDisplayLabel.Name = "daysDisplayLabel";
            this.daysDisplayLabel.Size = new System.Drawing.Size(0, 25);
            this.daysDisplayLabel.TabIndex = 4;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(48, 214);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(102, 25);
            this.secondsLabel.TabIndex = 3;
            this.secondsLabel.Text = "Seconds:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(48, 159);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(94, 25);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "Minutes:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(48, 110);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(75, 25);
            this.hoursLabel.TabIndex = 1;
            this.hoursLabel.Text = "Hours:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(48, 55);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(67, 25);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Days:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(37, 440);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 45);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "C&alculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(182, 440);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 45);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(324, 440);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 45);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // timeCalculator
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(497, 530);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultsGroupbox);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "timeCalculator";
            this.Text = "Time Calculator";
            this.resultsGroupbox.ResumeLayout(false);
            this.resultsGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.GroupBox resultsGroupbox;
        private System.Windows.Forms.Label secondsDisplayLabel;
        private System.Windows.Forms.Label minutesDisplayLabel;
        private System.Windows.Forms.Label hoursDisplayLabel;
        private System.Windows.Forms.Label daysDisplayLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

