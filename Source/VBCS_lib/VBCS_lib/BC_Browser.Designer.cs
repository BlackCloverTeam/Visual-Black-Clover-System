namespace VBCS_lib
{
    partial class BC_Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BC_Browser));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(855, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-6, 100);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1041, 635);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.FileDownload += new System.EventHandler(this.webBrowser1_FileDownload);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(992, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(883, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "GO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(992, 3);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(43, 40);
            this.CloseBut.TabIndex = 6;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // BC_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1038, 757);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BC_Browser";
            this.Text = "BC Browser";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox CloseBut;
    }
}