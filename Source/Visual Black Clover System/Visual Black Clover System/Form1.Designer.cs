namespace Visual_Black_Clover_System
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Hello_Logo = new System.Windows.Forms.PictureBox();
            this.starting_system = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hello_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Hello_Logo
            // 
            this.Hello_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hello_Logo.BackgroundImage")));
            this.Hello_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Hello_Logo.InitialImage")));
            this.Hello_Logo.Location = new System.Drawing.Point(444, 48);
            this.Hello_Logo.Name = "Hello_Logo";
            this.Hello_Logo.Size = new System.Drawing.Size(1087, 1032);
            this.Hello_Logo.TabIndex = 0;
            this.Hello_Logo.TabStop = false;
            // 
            // starting_system
            // 
            this.starting_system.Enabled = true;
            this.starting_system.Interval = 3000;
            this.starting_system.Tick += new System.EventHandler(this.starting_system_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1647, 1060);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "visual black clover system alpha 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1647, 1080);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "© black clover 2014-2016";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1916, 1094);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hello_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visual Black Clover System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hello_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hello_Logo;
        private System.Windows.Forms.Timer starting_system;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

