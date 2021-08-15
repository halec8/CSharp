namespace DayOfTheWeekHale
{
    partial class dayOfTheWeek
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
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.dayDisplayLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dayOfWeekLabel.Location = new System.Drawing.Point(20, 171);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(174, 27);
            this.dayOfWeekLabel.TabIndex = 0;
            this.dayOfWeekLabel.Text = "Day of the week:";
            this.dayOfWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayDisplayLabel
            // 
            this.dayDisplayLabel.AutoSize = true;
            this.dayDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dayDisplayLabel.Location = new System.Drawing.Point(209, 171);
            this.dayDisplayLabel.Name = "dayDisplayLabel";
            this.dayDisplayLabel.Size = new System.Drawing.Size(2, 27);
            this.dayDisplayLabel.TabIndex = 1;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(267, 79);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(129, 31);
            this.numberTextBox.TabIndex = 2;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.promptLabel.Location = new System.Drawing.Point(20, 58);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(228, 52);
            this.promptLabel.TabIndex = 3;
            this.promptLabel.Text = "Enter a number for\r\nthe corresponding day";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.Location = new System.Drawing.Point(20, 266);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(111, 39);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.Location = new System.Drawing.Point(148, 266);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 39);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(287, 266);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 39);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dayOfTheWeek
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(418, 338);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.dayDisplayLabel);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Name = "dayOfTheWeek";
            this.ShowIcon = false;
            this.Text = "Day of the Week";
            this.Load += new System.EventHandler(this.DayOfTheWeek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeekLabel;
        private System.Windows.Forms.Label dayDisplayLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

