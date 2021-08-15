namespace TextboxDemo
{
    partial class textBoxdemo
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
            this.userInputtextbox = new System.Windows.Forms.TextBox();
            this.userOutputtextbox = new System.Windows.Forms.TextBox();
            this.userInputlabel = new System.Windows.Forms.Label();
            this.userOutputlabel = new System.Windows.Forms.Label();
            this.readUserinputbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInputtextbox
            // 
            this.userInputtextbox.Location = new System.Drawing.Point(248, 65);
            this.userInputtextbox.Name = "userInputtextbox";
            this.userInputtextbox.Size = new System.Drawing.Size(229, 31);
            this.userInputtextbox.TabIndex = 0;
            // 
            // userOutputtextbox
            // 
            this.userOutputtextbox.Location = new System.Drawing.Point(248, 135);
            this.userOutputtextbox.Name = "userOutputtextbox";
            this.userOutputtextbox.Size = new System.Drawing.Size(229, 31);
            this.userOutputtextbox.TabIndex = 1;
            // 
            // userInputlabel
            // 
            this.userInputlabel.AutoSize = true;
            this.userInputlabel.Location = new System.Drawing.Point(41, 71);
            this.userInputlabel.Name = "userInputlabel";
            this.userInputlabel.Size = new System.Drawing.Size(177, 25);
            this.userInputlabel.TabIndex = 2;
            this.userInputlabel.Text = "Enter Your Name";
            // 
            // userOutputlabel
            // 
            this.userOutputlabel.AutoSize = true;
            this.userOutputlabel.Location = new System.Drawing.Point(41, 141);
            this.userOutputlabel.Name = "userOutputlabel";
            this.userOutputlabel.Size = new System.Drawing.Size(132, 25);
            this.userOutputlabel.TabIndex = 3;
            this.userOutputlabel.Text = "You Entered";
            // 
            // readUserinputbutton
            // 
            this.readUserinputbutton.Location = new System.Drawing.Point(59, 209);
            this.readUserinputbutton.Name = "readUserinputbutton";
            this.readUserinputbutton.Size = new System.Drawing.Size(172, 46);
            this.readUserinputbutton.TabIndex = 4;
            this.readUserinputbutton.Text = "&Read Input";
            this.readUserinputbutton.UseVisualStyleBackColor = true;
            this.readUserinputbutton.Click += new System.EventHandler(this.ReadUserinputbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(267, 209);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(155, 46);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // textBoxdemo
            // 
            this.AcceptButton = this.readUserinputbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(492, 307);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readUserinputbutton);
            this.Controls.Add(this.userOutputlabel);
            this.Controls.Add(this.userInputlabel);
            this.Controls.Add(this.userOutputtextbox);
            this.Controls.Add(this.userInputtextbox);
            this.Name = "textBoxdemo";
            this.Text = "Textbox Demo";
            this.Load += new System.EventHandler(this.TextBoxdemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputtextbox;
        private System.Windows.Forms.TextBox userOutputtextbox;
        private System.Windows.Forms.Label userInputlabel;
        private System.Windows.Forms.Label userOutputlabel;
        private System.Windows.Forms.Button readUserinputbutton;
        private System.Windows.Forms.Button exitButton;
    }
}

