namespace VBCS_lib
{
    partial class BC_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BC_Edit));
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SAVE = new System.Windows.Forms.Button();
            this.COMPILE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(635, -1);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(51, 37);
            this.CloseBut.TabIndex = 0;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(672, 404);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(2, -1);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(110, 41);
            this.SAVE.TabIndex = 2;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // COMPILE
            // 
            this.COMPILE.Location = new System.Drawing.Point(118, -1);
            this.COMPILE.Name = "COMPILE";
            this.COMPILE.Size = new System.Drawing.Size(110, 41);
            this.COMPILE.TabIndex = 3;
            this.COMPILE.Text = "COMPILE";
            this.COMPILE.UseVisualStyleBackColor = true;
            this.COMPILE.Click += new System.EventHandler(this.COMPILE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            this.label1.Visible = false;
            // 
            // BC_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(674, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COMPILE);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CloseBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BC_Edit";
            this.Text = "BC Edit";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBut;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button COMPILE;
        public System.Windows.Forms.Label label1;
    }
}