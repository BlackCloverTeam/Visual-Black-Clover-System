namespace VBCS_lib
{
    partial class FileWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileWindow));
            this.filebut = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.wind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wind)).BeginInit();
            this.SuspendLayout();
            // 
            // filebut
            // 
            this.filebut.Location = new System.Drawing.Point(1, 2);
            this.filebut.Name = "filebut";
            this.filebut.Size = new System.Drawing.Size(109, 33);
            this.filebut.TabIndex = 6;
            this.filebut.Text = "files";
            this.filebut.UseVisualStyleBackColor = true;
            // 
            // CloseBut
            // 
            this.CloseBut.Image = ((System.Drawing.Image)(resources.GetObject("CloseBut.Image")));
            this.CloseBut.InitialImage = null;
            this.CloseBut.Location = new System.Drawing.Point(710, 2);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(35, 33);
            this.CloseBut.TabIndex = 5;
            this.CloseBut.TabStop = false;
            // 
            // wind
            // 
            this.wind.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wind.Location = new System.Drawing.Point(0, 2);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(745, 33);
            this.wind.TabIndex = 4;
            this.wind.TabStop = false;
            // 
            // FileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 513);
            this.Controls.Add(this.filebut);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.wind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileWindow";
            this.Text = "FileWindow";
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filebut;
        private System.Windows.Forms.PictureBox CloseBut;
        private System.Windows.Forms.PictureBox wind;
    }
}