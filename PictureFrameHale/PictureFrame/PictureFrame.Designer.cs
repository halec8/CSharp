namespace PictureFrame
{
    partial class PictureFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureFrame));
            this.picFramePictureBox = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.photoList = new System.Windows.Forms.ImageList(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFramePictureBox)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFramePictureBox
            // 
            this.picFramePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFramePictureBox.Location = new System.Drawing.Point(72, 75);
            this.picFramePictureBox.Name = "picFramePictureBox";
            this.picFramePictureBox.Size = new System.Drawing.Size(256, 256);
            this.picFramePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFramePictureBox.TabIndex = 0;
            this.picFramePictureBox.TabStop = false;
            this.picFramePictureBox.Click += new System.EventHandler(this.PicFramePictureBox_Click);
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(422, 40);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.helpToolStripMenuItem.Text = "Clear";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.HelpToolStripMenuItem1_Click);
            // 
            // photoList
            // 
            this.photoList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("photoList.ImageStream")));
            this.photoList.TransparentColor = System.Drawing.Color.Transparent;
            this.photoList.Images.SetKeyName(0, "Danmachi1.png");
            this.photoList.Images.SetKeyName(1, "YourLieInApril1.png");
            this.photoList.Images.SetKeyName(2, "YourNamePicture3.png");
            this.photoList.Images.SetKeyName(3, "YourNamePicture2.png");
            this.photoList.Images.SetKeyName(4, "YourNamePicture1.png");
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(29, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 56);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(223, 365);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(156, 56);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PictureFrame
            // 
            this.AcceptButton = this.clearButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(422, 433);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.picFramePictureBox);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "PictureFrame";
            this.Text = "Picture Frame";
            this.Load += new System.EventHandler(this.PictureFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFramePictureBox)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFramePictureBox;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ImageList photoList;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

