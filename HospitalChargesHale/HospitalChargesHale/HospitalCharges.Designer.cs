namespace HospitalChargesHale
{
    partial class HospitalCharges
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.daysSpentlabel = new System.Windows.Forms.Label();
            this.medChargeslabel = new System.Windows.Forms.Label();
            this.surgicalChargeslabel = new System.Windows.Forms.Label();
            this.labFeeslabel = new System.Windows.Forms.Label();
            this.physRehabchargeslabel = new System.Windows.Forms.Label();
            this.daysTextbox = new System.Windows.Forms.TextBox();
            this.medChargesTextbox = new System.Windows.Forms.TextBox();
            this.surgicalChargeTextbox = new System.Windows.Forms.TextBox();
            this.labFeeTextbox = new System.Windows.Forms.TextBox();
            this.physRehabTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalChargeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stayChargesLabel = new System.Windows.Forms.Label();
            this.totalStayChargesLabel = new System.Windows.Forms.Label();
            this.miscChargesLabel = new System.Windows.Forms.Label();
            this.totalMiscChargesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysSpentlabel
            // 
            this.daysSpentlabel.AutoSize = true;
            this.daysSpentlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysSpentlabel.Location = new System.Drawing.Point(48, 43);
            this.daysSpentlabel.Name = "daysSpentlabel";
            this.daysSpentlabel.Size = new System.Drawing.Size(268, 27);
            this.daysSpentlabel.TabIndex = 0;
            this.daysSpentlabel.Text = "Days spent in the hospital:";
            // 
            // medChargeslabel
            // 
            this.medChargeslabel.AutoSize = true;
            this.medChargeslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medChargeslabel.Location = new System.Drawing.Point(48, 106);
            this.medChargeslabel.Name = "medChargeslabel";
            this.medChargeslabel.Size = new System.Drawing.Size(208, 27);
            this.medChargeslabel.TabIndex = 1;
            this.medChargeslabel.Text = "Medication charges:";
            // 
            // surgicalChargeslabel
            // 
            this.surgicalChargeslabel.AutoSize = true;
            this.surgicalChargeslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surgicalChargeslabel.Location = new System.Drawing.Point(48, 169);
            this.surgicalChargeslabel.Name = "surgicalChargeslabel";
            this.surgicalChargeslabel.Size = new System.Drawing.Size(181, 27);
            this.surgicalChargeslabel.TabIndex = 2;
            this.surgicalChargeslabel.Text = "Surgical charges:";
            // 
            // labFeeslabel
            // 
            this.labFeeslabel.AutoSize = true;
            this.labFeeslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labFeeslabel.Location = new System.Drawing.Point(48, 224);
            this.labFeeslabel.Name = "labFeeslabel";
            this.labFeeslabel.Size = new System.Drawing.Size(103, 27);
            this.labFeeslabel.TabIndex = 3;
            this.labFeeslabel.Text = "Lab fees:";
            // 
            // physRehabchargeslabel
            // 
            this.physRehabchargeslabel.AutoSize = true;
            this.physRehabchargeslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.physRehabchargeslabel.Location = new System.Drawing.Point(48, 286);
            this.physRehabchargeslabel.Name = "physRehabchargeslabel";
            this.physRehabchargeslabel.Size = new System.Drawing.Size(257, 27);
            this.physRehabchargeslabel.TabIndex = 4;
            this.physRehabchargeslabel.Text = "Physical Rehab Charges:";
            // 
            // daysTextbox
            // 
            this.daysTextbox.Location = new System.Drawing.Point(376, 43);
            this.daysTextbox.Name = "daysTextbox";
            this.daysTextbox.Size = new System.Drawing.Size(149, 31);
            this.daysTextbox.TabIndex = 5;
            // 
            // medChargesTextbox
            // 
            this.medChargesTextbox.Location = new System.Drawing.Point(376, 106);
            this.medChargesTextbox.Name = "medChargesTextbox";
            this.medChargesTextbox.Size = new System.Drawing.Size(149, 31);
            this.medChargesTextbox.TabIndex = 6;
            // 
            // surgicalChargeTextbox
            // 
            this.surgicalChargeTextbox.Location = new System.Drawing.Point(376, 169);
            this.surgicalChargeTextbox.Name = "surgicalChargeTextbox";
            this.surgicalChargeTextbox.Size = new System.Drawing.Size(149, 31);
            this.surgicalChargeTextbox.TabIndex = 7;
            // 
            // labFeeTextbox
            // 
            this.labFeeTextbox.Location = new System.Drawing.Point(376, 224);
            this.labFeeTextbox.Name = "labFeeTextbox";
            this.labFeeTextbox.Size = new System.Drawing.Size(149, 31);
            this.labFeeTextbox.TabIndex = 8;
            // 
            // physRehabTextbox
            // 
            this.physRehabTextbox.Location = new System.Drawing.Point(376, 286);
            this.physRehabTextbox.Name = "physRehabTextbox";
            this.physRehabTextbox.Size = new System.Drawing.Size(149, 31);
            this.physRehabTextbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(119, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Hospital Charges:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalChargeLabel
            // 
            this.totalChargeLabel.AutoSize = true;
            this.totalChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargeLabel.Location = new System.Drawing.Point(360, 471);
            this.totalChargeLabel.Name = "totalChargeLabel";
            this.totalChargeLabel.Size = new System.Drawing.Size(2, 27);
            this.totalChargeLabel.TabIndex = 11;
            this.totalChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Silver;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Location = new System.Drawing.Point(48, 546);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(135, 45);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(256, 546);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(129, 45);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Silver;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(445, 546);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 45);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // stayChargesLabel
            // 
            this.stayChargesLabel.AutoSize = true;
            this.stayChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stayChargesLabel.Location = new System.Drawing.Point(119, 345);
            this.stayChargesLabel.Name = "stayChargesLabel";
            this.stayChargesLabel.Size = new System.Drawing.Size(197, 27);
            this.stayChargesLabel.TabIndex = 15;
            this.stayChargesLabel.Text = "Total stay charges:";
            this.stayChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalStayChargesLabel
            // 
            this.totalStayChargesLabel.AutoSize = true;
            this.totalStayChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalStayChargesLabel.Location = new System.Drawing.Point(360, 345);
            this.totalStayChargesLabel.Name = "totalStayChargesLabel";
            this.totalStayChargesLabel.Size = new System.Drawing.Size(2, 27);
            this.totalStayChargesLabel.TabIndex = 16;
            // 
            // miscChargesLabel
            // 
            this.miscChargesLabel.AutoSize = true;
            this.miscChargesLabel.Location = new System.Drawing.Point(114, 408);
            this.miscChargesLabel.Name = "miscChargesLabel";
            this.miscChargesLabel.Size = new System.Drawing.Size(199, 25);
            this.miscChargesLabel.TabIndex = 17;
            this.miscChargesLabel.Text = "Total misc charges:";
            // 
            // totalMiscChargesLabel
            // 
            this.totalMiscChargesLabel.AutoSize = true;
            this.totalMiscChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalMiscChargesLabel.Location = new System.Drawing.Point(360, 407);
            this.totalMiscChargesLabel.Name = "totalMiscChargesLabel";
            this.totalMiscChargesLabel.Size = new System.Drawing.Size(2, 27);
            this.totalMiscChargesLabel.TabIndex = 18;
            // 
            // HospitalCharges
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(612, 629);
            this.Controls.Add(this.totalMiscChargesLabel);
            this.Controls.Add(this.miscChargesLabel);
            this.Controls.Add(this.totalStayChargesLabel);
            this.Controls.Add(this.stayChargesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalChargeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.physRehabTextbox);
            this.Controls.Add(this.labFeeTextbox);
            this.Controls.Add(this.surgicalChargeTextbox);
            this.Controls.Add(this.medChargesTextbox);
            this.Controls.Add(this.daysTextbox);
            this.Controls.Add(this.physRehabchargeslabel);
            this.Controls.Add(this.labFeeslabel);
            this.Controls.Add(this.surgicalChargeslabel);
            this.Controls.Add(this.medChargeslabel);
            this.Controls.Add(this.daysSpentlabel);
            this.Name = "HospitalCharges";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label daysSpentlabel;
        public System.Windows.Forms.Label medChargeslabel;
        public System.Windows.Forms.Label surgicalChargeslabel;
        public System.Windows.Forms.Label labFeeslabel;
        public System.Windows.Forms.Label physRehabchargeslabel;
        public System.Windows.Forms.TextBox daysTextbox;
        public System.Windows.Forms.TextBox medChargesTextbox;
        public System.Windows.Forms.TextBox surgicalChargeTextbox;
        public System.Windows.Forms.TextBox labFeeTextbox;
        public System.Windows.Forms.TextBox physRehabTextbox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label totalChargeLabel;
        public System.Windows.Forms.Button calculateButton;
        public System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.Label stayChargesLabel;
        public System.Windows.Forms.Label totalStayChargesLabel;
        public System.Windows.Forms.Label miscChargesLabel; 
        public System.Windows.Forms.Label totalMiscChargesLabel;
    }
}

