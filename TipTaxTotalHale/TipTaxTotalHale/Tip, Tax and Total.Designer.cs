namespace TipTaxTotalHale
{
    partial class TipTaxTotal
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
            this.foodLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.foodCostTextbox = new System.Windows.Forms.TextBox();
            this.tipTextbox = new System.Windows.Forms.TextBox();
            this.taxTextbox = new System.Windows.Forms.TextBox();
            this.totalCostLabelbox = new System.Windows.Forms.Label();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodLabel.Location = new System.Drawing.Point(39, 62);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(119, 27);
            this.foodLabel.TabIndex = 0;
            this.foodLabel.Text = "Food Cost:";
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipLabel.Location = new System.Drawing.Point(39, 133);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(113, 27);
            this.tipLabel.TabIndex = 1;
            this.tipLabel.Text = "Tip (15%):";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(39, 204);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(107, 27);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "Tax (7%):";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(39, 283);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 27);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total";
            // 
            // foodCostTextbox
            // 
            this.foodCostTextbox.Location = new System.Drawing.Point(271, 56);
            this.foodCostTextbox.Name = "foodCostTextbox";
            this.foodCostTextbox.Size = new System.Drawing.Size(140, 31);
            this.foodCostTextbox.TabIndex = 4;
            // 
            // tipTextbox
            // 
            this.tipTextbox.Location = new System.Drawing.Point(271, 133);
            this.tipTextbox.Name = "tipTextbox";
            this.tipTextbox.Size = new System.Drawing.Size(140, 31);
            this.tipTextbox.TabIndex = 5;
            // 
            // taxTextbox
            // 
            this.taxTextbox.Location = new System.Drawing.Point(271, 198);
            this.taxTextbox.Name = "taxTextbox";
            this.taxTextbox.Size = new System.Drawing.Size(140, 31);
            this.taxTextbox.TabIndex = 6;
            // 
            // totalCostLabelbox
            // 
            this.totalCostLabelbox.AutoSize = true;
            this.totalCostLabelbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostLabelbox.Location = new System.Drawing.Point(271, 281);
            this.totalCostLabelbox.Name = "totalCostLabelbox";
            this.totalCostLabelbox.Size = new System.Drawing.Size(2, 27);
            this.totalCostLabelbox.TabIndex = 7;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(44, 378);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(160, 80);
            this.calculateTotalButton.TabIndex = 8;
            this.calculateTotalButton.Text = "&Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.CalculateTotalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(238, 378);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(148, 80);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(421, 378);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 80);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TipTaxTotal
            // 
            this.AcceptButton = this.calculateTotalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(616, 519);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.totalCostLabelbox);
            this.Controls.Add(this.taxTextbox);
            this.Controls.Add(this.tipTextbox);
            this.Controls.Add(this.foodCostTextbox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.foodLabel);
            this.Name = "TipTaxTotal";
            this.Text = "Tip, Tax, and Total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox foodCostTextbox;
        private System.Windows.Forms.TextBox tipTextbox;
        private System.Windows.Forms.TextBox taxTextbox;
        private System.Windows.Forms.Label totalCostLabelbox;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

