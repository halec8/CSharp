namespace Friend_File
{
    partial class FriendFile
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
            this.exitButton = new System.Windows.Forms.Button();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(344, 388);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 44);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(33, 308);
            this.writeNameButton.Margin = new System.Windows.Forms.Padding(6);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(150, 44);
            this.writeNameButton.TabIndex = 6;
            this.writeNameButton.Text = "W&rite Name";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.WriteNameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(258, 33);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 31);
            this.nameTextBox.TabIndex = 5;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(28, 38);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(221, 25);
            this.promptLabel.TabIndex = 4;
            this.promptLabel.Text = "Enter a friend\'s name:";
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 25;
            this.nameListBox.Location = new System.Drawing.Point(171, 93);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(247, 179);
            this.nameListBox.TabIndex = 9;
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(344, 308);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(152, 44);
            this.readFileButton.TabIndex = 10;
            this.readFileButton.Text = "Read File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(33, 388);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 41);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FriendFile
            // 
            this.AcceptButton = this.writeNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(589, 447);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FriendFile";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Button clearButton;
    }
}

