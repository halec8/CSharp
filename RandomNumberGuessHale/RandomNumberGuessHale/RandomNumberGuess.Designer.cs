namespace RandomNumberGuessHale
{
    partial class RandomNumberGuess
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
            this.userInputTextbox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promptLabel.Location = new System.Drawing.Point(114, 43);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(233, 27);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Guess a number 1-100";
            this.promptLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // userInputTextbox
            // 
            this.userInputTextbox.Location = new System.Drawing.Point(151, 103);
            this.userInputTextbox.Name = "userInputTextbox";
            this.userInputTextbox.Size = new System.Drawing.Size(148, 31);
            this.userInputTextbox.TabIndex = 1;
            this.userInputTextbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(31, 167);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(124, 44);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(314, 167);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 44);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(171, 167);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 44);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RandomNumberGuess
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(431, 244);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.userInputTextbox);
            this.Controls.Add(this.promptLabel);
            this.Name = "RandomNumberGuess";
            this.Text = "Number Guess Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox userInputTextbox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

