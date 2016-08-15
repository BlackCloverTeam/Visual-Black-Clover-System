namespace VBCS_lib
{
    partial class VBCS_File
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VBCS_File));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wind = new System.Windows.Forms.PictureBox();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.filebut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 477);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(717, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "/goroot";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // wind
            // 
            this.wind.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wind.Location = new System.Drawing.Point(0, -3);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(745, 33);
            this.wind.TabIndex = 1;
            this.wind.TabStop = false;
            // 
            // CloseBut
            // 
            this.CloseBut.Image = ((System.Drawing.Image)(resources.GetObject("CloseBut.Image")));
            this.CloseBut.InitialImage = null;
            this.CloseBut.Location = new System.Drawing.Point(709, -3);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(35, 33);
            this.CloseBut.TabIndex = 2;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // filebut
            // 
            this.filebut.Location = new System.Drawing.Point(0, -3);
            this.filebut.Name = "filebut";
            this.filebut.Size = new System.Drawing.Size(109, 33);
            this.filebut.TabIndex = 3;
            this.filebut.Text = "files";
            this.filebut.UseVisualStyleBackColor = true;
            this.filebut.Click += new System.EventHandler(this.filebut_Click);
            // 
            // VBCS_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 520);
            this.Controls.Add(this.filebut);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VBCS_File";
            this.Text = "VBCS File System";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox wind;
        private System.Windows.Forms.PictureBox CloseBut;
        private System.Windows.Forms.Button filebut;

    }
}