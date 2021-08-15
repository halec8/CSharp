namespace Array_Argument
{
    partial class ArrayArgumentSorted
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.findMaxButton = new System.Windows.Forms.Button();
            this.findMinButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 25;
            this.outputListBox.Location = new System.Drawing.Point(43, 32);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(6);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(372, 254);
            this.outputListBox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(52, 306);
            this.goButton.Margin = new System.Windows.Forms.Padding(6);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(144, 44);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "&Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(246, 306);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(147, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // findMaxButton
            // 
            this.findMaxButton.Location = new System.Drawing.Point(431, 54);
            this.findMaxButton.Name = "findMaxButton";
            this.findMaxButton.Size = new System.Drawing.Size(138, 55);
            this.findMaxButton.TabIndex = 3;
            this.findMaxButton.Text = "Find max";
            this.findMaxButton.UseVisualStyleBackColor = true;
            this.findMaxButton.Click += new System.EventHandler(this.FindMaxButton_Click);
            // 
            // findMinButton
            // 
            this.findMinButton.Location = new System.Drawing.Point(431, 142);
            this.findMinButton.Name = "findMinButton";
            this.findMinButton.Size = new System.Drawing.Size(138, 53);
            this.findMinButton.TabIndex = 4;
            this.findMinButton.Text = "Find min";
            this.findMinButton.UseVisualStyleBackColor = true;
            this.findMinButton.Click += new System.EventHandler(this.FindMinButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(431, 230);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(138, 44);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(431, 306);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(138, 43);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ArrayArgument
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(589, 391);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.findMinButton);
            this.Controls.Add(this.findMaxButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.outputListBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ArrayArgument";
            this.Text = "Array Argument";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button findMaxButton;
        private System.Windows.Forms.Button findMinButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button clearButton;
    }
}

