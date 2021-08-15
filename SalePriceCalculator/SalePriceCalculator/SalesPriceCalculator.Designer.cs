namespace SalePriceCalculator
{
    partial class salePriceCalc
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
            this.originalPricepromptlabel = new System.Windows.Forms.Label();
            this.discPercentagepromptlabel = new System.Windows.Forms.Label();
            this.outputDescriptionlabel = new System.Windows.Forms.Label();
            this.salePricelabel = new System.Windows.Forms.Label();
            this.originalPricetextbox = new System.Windows.Forms.TextBox();
            this.discountPercentagetextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPricepromptlabel
            // 
            this.originalPricepromptlabel.AutoSize = true;
            this.originalPricepromptlabel.Location = new System.Drawing.Point(39, 66);
            this.originalPricepromptlabel.Name = "originalPricepromptlabel";
            this.originalPricepromptlabel.Size = new System.Drawing.Size(291, 25);
            this.originalPricepromptlabel.TabIndex = 0;
            this.originalPricepromptlabel.Text = "Enter the items original price:";
            this.originalPricepromptlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discPercentagepromptlabel
            // 
            this.discPercentagepromptlabel.AutoSize = true;
            this.discPercentagepromptlabel.Location = new System.Drawing.Point(39, 180);
            this.discPercentagepromptlabel.Name = "discPercentagepromptlabel";
            this.discPercentagepromptlabel.Size = new System.Drawing.Size(306, 25);
            this.discPercentagepromptlabel.TabIndex = 1;
            this.discPercentagepromptlabel.Text = "Enter the discount percentage:";
            this.discPercentagepromptlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionlabel
            // 
            this.outputDescriptionlabel.AutoSize = true;
            this.outputDescriptionlabel.Location = new System.Drawing.Point(216, 285);
            this.outputDescriptionlabel.Name = "outputDescriptionlabel";
            this.outputDescriptionlabel.Size = new System.Drawing.Size(114, 25);
            this.outputDescriptionlabel.TabIndex = 2;
            this.outputDescriptionlabel.Text = "Sale price:";
            this.outputDescriptionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salePricelabel
            // 
            this.salePricelabel.AutoSize = true;
            this.salePricelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePricelabel.Location = new System.Drawing.Point(392, 285);
            this.salePricelabel.Name = "salePricelabel";
            this.salePricelabel.Size = new System.Drawing.Size(2, 27);
            this.salePricelabel.TabIndex = 3;
            this.salePricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // originalPricetextbox
            // 
            this.originalPricetextbox.Location = new System.Drawing.Point(392, 60);
            this.originalPricetextbox.Name = "originalPricetextbox";
            this.originalPricetextbox.Size = new System.Drawing.Size(130, 31);
            this.originalPricetextbox.TabIndex = 4;
            this.originalPricetextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discountPercentagetextbox
            // 
            this.discountPercentagetextbox.Location = new System.Drawing.Point(392, 174);
            this.discountPercentagetextbox.Name = "discountPercentagetextbox";
            this.discountPercentagetextbox.Size = new System.Drawing.Size(130, 31);
            this.discountPercentagetextbox.TabIndex = 5;
            this.discountPercentagetextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(44, 428);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(160, 72);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate sale price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(503, 428);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 72);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(274, 428);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(158, 71);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // salePriceCalc
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(725, 552);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.discountPercentagetextbox);
            this.Controls.Add(this.originalPricetextbox);
            this.Controls.Add(this.salePricelabel);
            this.Controls.Add(this.outputDescriptionlabel);
            this.Controls.Add(this.discPercentagepromptlabel);
            this.Controls.Add(this.originalPricepromptlabel);
            this.Name = "salePriceCalc";
            this.Text = "Sale Price Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalPricepromptlabel;
        private System.Windows.Forms.Label discPercentagepromptlabel;
        private System.Windows.Forms.Label outputDescriptionlabel;
        private System.Windows.Forms.Label salePricelabel;
        private System.Windows.Forms.TextBox originalPricetextbox;
        private System.Windows.Forms.TextBox discountPercentagetextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

