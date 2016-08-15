namespace VBCS_boot
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.OK_but = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO VISUAL BLACK CLOVER SYSTEM!";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(358, 285);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(501, 32);
            this.name.TabIndex = 2;
            // 
            // passtext
            // 
            this.passtext.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passtext.Location = new System.Drawing.Point(358, 353);
            this.passtext.Margin = new System.Windows.Forms.Padding(4);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(501, 32);
            this.passtext.TabIndex = 3;
            this.passtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passtext_KeyDown);
            // 
            // OK_but
            // 
            this.OK_but.Location = new System.Drawing.Point(536, 402);
            this.OK_but.Name = "OK_but";
            this.OK_but.Size = new System.Drawing.Size(133, 38);
            this.OK_but.TabIndex = 4;
            this.OK_but.Text = "GO";
            this.OK_but.UseVisualStyleBackColor = true;
            this.OK_but.Click += new System.EventHandler(this.OK_but_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(485, 464);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(0, 21);
            this.ErrorText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 942);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.OK_but);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Button OK_but;
        private System.Windows.Forms.Label ErrorText;
    }
}

