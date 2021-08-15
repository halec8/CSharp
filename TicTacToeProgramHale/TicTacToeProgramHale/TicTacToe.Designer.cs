using System;

namespace TicTacToeProgramHale
{
    partial class TicTacToe
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(76, 376);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(116, 69);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "&New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.ClearBoard_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(214, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 69);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Enabled = false;
            this.gameNameLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gameNameLabel.Location = new System.Drawing.Point(137, 9);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(142, 25);
            this.gameNameLabel.TabIndex = 4;
            this.gameNameLabel.Text = "TIC TAC TOE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.ExitGameToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(35, 67);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(97, 82);
            this.a1.TabIndex = 6;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.button_click);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(151, 67);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(98, 82);
            this.a2.TabIndex = 7;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.button_click);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(271, 67);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(96, 82);
            this.a3.TabIndex = 8;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.button_click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(35, 169);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(97, 83);
            this.b1.TabIndex = 9;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(151, 169);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(98, 83);
            this.b2.TabIndex = 10;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(271, 169);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(96, 83);
            this.b3.TabIndex = 11;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_click);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(35, 267);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(97, 83);
            this.c1.TabIndex = 12;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.button_click);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(151, 267);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(98, 83);
            this.c2.TabIndex = 13;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.button_click);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(271, 267);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(96, 83);
            this.c3.TabIndex = 14;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.button_click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 458);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
    }
}

