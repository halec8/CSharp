namespace TimeCalculator
{
    partial class TimeCalculator
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
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.enterSecondsPrompt = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.displaySecondsLabel = new System.Windows.Forms.Label();
            this.displayHoursLabel = new System.Windows.Forms.Label();
            this.displayDayLabel = new System.Windows.Forms.Label();
            this.displayMinutesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(129, 19);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(111, 20);
            this.secondsTextBox.TabIndex = 0;
            // 
            // enterSecondsPrompt
            // 
            this.enterSecondsPrompt.AutoSize = true;
            this.enterSecondsPrompt.Location = new System.Drawing.Point(35, 19);
            this.enterSecondsPrompt.Name = "enterSecondsPrompt";
            this.enterSecondsPrompt.Size = new System.Drawing.Size(78, 13);
            this.enterSecondsPrompt.TabIndex = 1;
            this.enterSecondsPrompt.Text = "Enter seconds:";
            // 
            // resultsBox
            // 
            this.resultsBox.Controls.Add(this.displaySecondsLabel);
            this.resultsBox.Controls.Add(this.displayHoursLabel);
            this.resultsBox.Controls.Add(this.displayDayLabel);
            this.resultsBox.Controls.Add(this.displayMinutesLabel);
            this.resultsBox.Controls.Add(this.label4);
            this.resultsBox.Controls.Add(this.label3);
            this.resultsBox.Controls.Add(this.label2);
            this.resultsBox.Controls.Add(this.label1);
            this.resultsBox.Location = new System.Drawing.Point(38, 45);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(202, 121);
            this.resultsBox.TabIndex = 2;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results";
            // 
            // displaySecondsLabel
            // 
            this.displaySecondsLabel.AutoSize = true;
            this.displaySecondsLabel.Location = new System.Drawing.Point(100, 94);
            this.displaySecondsLabel.Name = "displaySecondsLabel";
            this.displaySecondsLabel.Size = new System.Drawing.Size(0, 13);
            this.displaySecondsLabel.TabIndex = 7;
            // 
            // displayHoursLabel
            // 
            this.displayHoursLabel.AutoSize = true;
            this.displayHoursLabel.Location = new System.Drawing.Point(100, 41);
            this.displayHoursLabel.Name = "displayHoursLabel";
            this.displayHoursLabel.Size = new System.Drawing.Size(0, 13);
            this.displayHoursLabel.TabIndex = 6;
            // 
            // displayDayLabel
            // 
            this.displayDayLabel.AutoSize = true;
            this.displayDayLabel.Location = new System.Drawing.Point(100, 16);
            this.displayDayLabel.Name = "displayDayLabel";
            this.displayDayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayDayLabel.TabIndex = 5;
            // 
            // displayMinutesLabel
            // 
            this.displayMinutesLabel.AutoSize = true;
            this.displayMinutesLabel.Location = new System.Drawing.Point(100, 67);
            this.displayMinutesLabel.Name = "displayMinutesLabel";
            this.displayMinutesLabel.Size = new System.Drawing.Size(0, 13);
            this.displayMinutesLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seconds:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minutes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(38, 182);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(65, 37);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "C&alculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(175, 182);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 37);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.clearBtn.Location = new System.Drawing.Point(104, 182);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(65, 37);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // TimeCalculator
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(282, 269);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.enterSecondsPrompt);
            this.Controls.Add(this.secondsTextBox);
            this.Name = "TimeCalculator";
            this.Text = "Time Calculator";
            this.resultsBox.ResumeLayout(false);
            this.resultsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label enterSecondsPrompt;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.Label displaySecondsLabel;
        private System.Windows.Forms.Label displayHoursLabel;
        private System.Windows.Forms.Label displayDayLabel;
        private System.Windows.Forms.Label displayMinutesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearBtn;
    }
}

