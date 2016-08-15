namespace VBCS_lib
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.plus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.umn = new System.Windows.Forms.Button();
            this.dev = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.DelBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(11, 425);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(73, 59);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 1;
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(10, 87);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(73, 59);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // umn
            // 
            this.umn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umn.Location = new System.Drawing.Point(119, 87);
            this.umn.Name = "umn";
            this.umn.Size = new System.Drawing.Size(73, 59);
            this.umn.TabIndex = 3;
            this.umn.Text = "*";
            this.umn.UseVisualStyleBackColor = true;
            this.umn.Click += new System.EventHandler(this.umn_Click);
            // 
            // dev
            // 
            this.dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dev.Location = new System.Drawing.Point(225, 87);
            this.dev.Name = "dev";
            this.dev.Size = new System.Drawing.Size(73, 59);
            this.dev.TabIndex = 4;
            this.dev.Text = "/";
            this.dev.UseVisualStyleBackColor = true;
            this.dev.Click += new System.EventHandler(this.dev_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(225, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 59);
            this.button5.TabIndex = 8;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // but2
            // 
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but2.Location = new System.Drawing.Point(119, 168);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(73, 59);
            this.but2.TabIndex = 7;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but1
            // 
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but1.Location = new System.Drawing.Point(10, 168);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(73, 59);
            this.but1.TabIndex = 6;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but0
            // 
            this.but0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but0.Location = new System.Drawing.Point(120, 425);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(73, 59);
            this.but0.TabIndex = 5;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(226, 252);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 59);
            this.button9.TabIndex = 12;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(120, 252);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 59);
            this.button10.TabIndex = 11;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // but4
            // 
            this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but4.Location = new System.Drawing.Point(11, 252);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(73, 59);
            this.but4.TabIndex = 10;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // but9
            // 
            this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but9.Location = new System.Drawing.Point(225, 344);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(73, 59);
            this.but9.TabIndex = 16;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // but8
            // 
            this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but8.Location = new System.Drawing.Point(119, 344);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(73, 59);
            this.but8.TabIndex = 15;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but7
            // 
            this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but7.Location = new System.Drawing.Point(10, 344);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(73, 59);
            this.but7.TabIndex = 14;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(225, 425);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(73, 59);
            this.result.TabIndex = 17;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(264, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(46, 39);
            this.CloseBut.TabIndex = 18;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // DelBut
            // 
            this.DelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelBut.Location = new System.Drawing.Point(119, 512);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(73, 67);
            this.DelBut.TabIndex = 19;
            this.DelBut.Text = "C";
            this.DelBut.UseVisualStyleBackColor = true;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(313, 591);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.result);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.dev);
            this.Controls.Add(this.umn);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "BC Calculator";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button umn;
        private System.Windows.Forms.Button dev;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.PictureBox CloseBut;
        private System.Windows.Forms.Button DelBut;
    }
}