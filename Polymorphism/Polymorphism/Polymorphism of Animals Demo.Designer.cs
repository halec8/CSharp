﻿namespace Polymorphism
{
    partial class PolymorphismDemo
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
            this.createCatButton = new System.Windows.Forms.Button();
            this.createDogButton = new System.Windows.Forms.Button();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(232, 112);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 71);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // createCatButton
            // 
            this.createCatButton.Location = new System.Drawing.Point(394, 19);
            this.createCatButton.Margin = new System.Windows.Forms.Padding(6);
            this.createCatButton.Name = "createCatButton";
            this.createCatButton.Size = new System.Drawing.Size(150, 71);
            this.createCatButton.TabIndex = 6;
            this.createCatButton.Text = "Cr&eate a Cat";
            this.createCatButton.UseVisualStyleBackColor = true;
            this.createCatButton.Click += new System.EventHandler(this.CreateCatButton_Click);
            // 
            // createDogButton
            // 
            this.createDogButton.Location = new System.Drawing.Point(232, 19);
            this.createDogButton.Margin = new System.Windows.Forms.Padding(6);
            this.createDogButton.Name = "createDogButton";
            this.createDogButton.Size = new System.Drawing.Size(150, 75);
            this.createDogButton.TabIndex = 5;
            this.createDogButton.Text = "C&reate a Dog";
            this.createDogButton.UseVisualStyleBackColor = true;
            this.createDogButton.Click += new System.EventHandler(this.CreateDogButton_Click);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(70, 19);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(6);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(150, 75);
            this.createAnimalButton.TabIndex = 4;
            this.createAnimalButton.Text = "&Create an Animal";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.CreateAnimalButton_Click);
            // 
            // PolymorphismDemo
            // 
            this.AcceptButton = this.createAnimalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(612, 202);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createCatButton);
            this.Controls.Add(this.createDogButton);
            this.Controls.Add(this.createAnimalButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PolymorphismDemo";
            this.Text = "Polymorphism Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createCatButton;
        private System.Windows.Forms.Button createDogButton;
        private System.Windows.Forms.Button createAnimalButton;
    }
}

