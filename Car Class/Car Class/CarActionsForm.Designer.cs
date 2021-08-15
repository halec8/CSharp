namespace Car_Class
{
    partial class AccelerateBrake
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
            this.yearLabelBox = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.makeLabelBox = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.calculatedSpeedLabel = new System.Windows.Forms.Label();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearLabelBox
            // 
            this.yearLabelBox.AutoSize = true;
            this.yearLabelBox.Location = new System.Drawing.Point(57, 36);
            this.yearLabelBox.Name = "yearLabelBox";
            this.yearLabelBox.Size = new System.Drawing.Size(51, 13);
            this.yearLabelBox.TabIndex = 0;
            this.yearLabelBox.Text = "Car Year:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearLabel.Location = new System.Drawing.Point(116, 34);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(2, 15);
            this.yearLabel.TabIndex = 1;
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makeLabelBox
            // 
            this.makeLabelBox.AutoSize = true;
            this.makeLabelBox.Location = new System.Drawing.Point(57, 73);
            this.makeLabelBox.Name = "makeLabelBox";
            this.makeLabelBox.Size = new System.Drawing.Size(56, 13);
            this.makeLabelBox.TabIndex = 2;
            this.makeLabelBox.Text = "Car Make:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.makeLabel.Location = new System.Drawing.Point(116, 73);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(2, 15);
            this.makeLabel.TabIndex = 3;
            this.makeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(85, 118);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(81, 13);
            this.speedLabel.TabIndex = 4;
            this.speedLabel.Text = "Current Speed: ";
            // 
            // calculatedSpeedLabel
            // 
            this.calculatedSpeedLabel.AutoSize = true;
            this.calculatedSpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calculatedSpeedLabel.Location = new System.Drawing.Point(172, 118);
            this.calculatedSpeedLabel.Name = "calculatedSpeedLabel";
            this.calculatedSpeedLabel.Size = new System.Drawing.Size(2, 15);
            this.calculatedSpeedLabel.TabIndex = 5;
            this.calculatedSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(38, 163);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(75, 23);
            this.accelerateButton.TabIndex = 6;
            this.accelerateButton.Text = "&Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.AccelerateButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(135, 163);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(75, 23);
            this.brakeButton.TabIndex = 7;
            this.brakeButton.Text = "&Break";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.BrakeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(226, 163);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AccelerateBrake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(339, 201);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.accelerateButton);
            this.Controls.Add(this.calculatedSpeedLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.makeLabelBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearLabelBox);
            this.Name = "AccelerateBrake";
            this.Text = "Car Acceleration and Braking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLabelBox;
        public System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label makeLabelBox;
        public System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label speedLabel;
        public System.Windows.Forms.Label calculatedSpeedLabel;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Button closeButton;
    }
}