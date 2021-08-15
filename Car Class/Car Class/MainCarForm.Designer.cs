namespace Car_Class
{
    partial class CarAcceleration
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
            this.yearLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(82, 67);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(64, 25);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(82, 150);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(71, 25);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make:";
            // 
            // submitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitButton.Location = new System.Drawing.Point(68, 238);
            this.submitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(154, 50);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(308, 238);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 50);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(194, 54);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(196, 31);
            this.yearTextBox.TabIndex = 4;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(194, 137);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(196, 31);
            this.makeTextBox.TabIndex = 5;
            // 
            // CarAcceleration
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(508, 312);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.yearLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarAcceleration";
            this.Text = "Car Acceleration";
            this.Load += new System.EventHandler(this.CarAcceleration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
    }
}

