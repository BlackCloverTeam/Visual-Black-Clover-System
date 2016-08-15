namespace VBCS_lib
{
    partial class VBCS_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VBCS_Menu));
            this.EXIT = new System.Windows.Forms.Button();
            this.FILESYSTEM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.SETTINGS = new System.Windows.Forms.Button();
            this.MANUAL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(12, 53);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(370, 39);
            this.EXIT.TabIndex = 0;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // FILESYSTEM
            // 
            this.FILESYSTEM.Location = new System.Drawing.Point(12, 109);
            this.FILESYSTEM.Name = "FILESYSTEM";
            this.FILESYSTEM.Size = new System.Drawing.Size(370, 39);
            this.FILESYSTEM.TabIndex = 1;
            this.FILESYSTEM.Text = "FILESYSTEM";
            this.FILESYSTEM.UseVisualStyleBackColor = true;
            this.FILESYSTEM.Click += new System.EventHandler(this.FILESYSTEM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(361, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(56, 34);
            this.CloseBut.TabIndex = 3;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // SETTINGS
            // 
            this.SETTINGS.Location = new System.Drawing.Point(12, 165);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Size = new System.Drawing.Size(370, 39);
            this.SETTINGS.TabIndex = 4;
            this.SETTINGS.Text = "SETTINGS";
            this.SETTINGS.UseVisualStyleBackColor = true;
            this.SETTINGS.Click += new System.EventHandler(this.SETTINGS_Click);
            // 
            // MANUAL
            // 
            this.MANUAL.Location = new System.Drawing.Point(12, 221);
            this.MANUAL.Name = "MANUAL";
            this.MANUAL.Size = new System.Drawing.Size(370, 39);
            this.MANUAL.TabIndex = 5;
            this.MANUAL.Text = "MANUAL";
            this.MANUAL.UseVisualStyleBackColor = true;
            this.MANUAL.Click += new System.EventHandler(this.MANUAL_Click);
            // 
            // VBCS_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 282);
            this.Controls.Add(this.MANUAL);
            this.Controls.Add(this.SETTINGS);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FILESYSTEM);
            this.Controls.Add(this.EXIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 200);
            this.Name = "VBCS_Menu";
            this.Text = "VBCS Menu";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button FILESYSTEM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CloseBut;
        private System.Windows.Forms.Button SETTINGS;
        private System.Windows.Forms.Button MANUAL;
    }
}