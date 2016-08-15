namespace VBCS_lib
{
    partial class Terminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.Console = new System.Windows.Forms.RichTextBox();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.SystemColors.MenuText;
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Console.Cursor = System.Windows.Forms.Cursors.Default;
            this.Console.ForeColor = System.Drawing.SystemColors.Window;
            this.Console.Location = new System.Drawing.Point(2, 38);
            this.Console.Name = "Console";
            this.Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Console.Size = new System.Drawing.Size(650, 456);
            this.Console.TabIndex = 0;
            this.Console.Text = "";
            this.Console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Console_KeyDown);
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(606, -1);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(46, 40);
            this.CloseBut.TabIndex = 1;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(650, 494);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.Console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Terminal";
            this.Text = "BC Terminal";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.PictureBox CloseBut;
    }
}