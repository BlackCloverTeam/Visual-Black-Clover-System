namespace VBCS_lib
{
    partial class VBCS_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VBCS_Message));
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.Messagetext = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(279, 1);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(51, 37);
            this.CloseBut.TabIndex = 0;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // Messagetext
            // 
            this.Messagetext.AutoSize = true;
            this.Messagetext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Messagetext.Location = new System.Drawing.Point(107, 74);
            this.Messagetext.Name = "Messagetext";
            this.Messagetext.Size = new System.Drawing.Size(0, 20);
            this.Messagetext.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VBCS_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(316, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Messagetext);
            this.Controls.Add(this.CloseBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VBCS_Message";
            this.Text = "VBCS Message";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBut;
        public System.Windows.Forms.Label Messagetext;
        private System.Windows.Forms.Button button1;
    }
}