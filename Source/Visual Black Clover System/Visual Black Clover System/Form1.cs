using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using VBCS_lib;



/*          this.button1.Location = new System.Drawing.Point(100, 100);
            this.button1.Name = "button2";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 1;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;     */




namespace Visual_Black_Clover_System
{
    public partial class Form1 : Form
    {
        public Point DelPoint = new Point(10000);
        public string NowEXE;



        public Form1()
        {
            try
            {
                //string[] i = new string[5];
                //i[7] = "0";
                InitializeComponent();
            }
            catch
            {
                BlueScreen();
            }
        }

        private void starting_system_Tick(object sender, EventArgs e)
        {
            try
            {
                Hello_Logo.Location = DelPoint;
                this.BackgroundImage = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/Desktop.jpg");
                RenderDesktop();
            }
            catch
            {
                BlueScreen();
            }
        }


        public void RenderDesktop()
        {
            try
            {


                Button vbcs = new Button();
                vbcs.Size = new System.Drawing.Size(70, 70);
                vbcs.Location = new System.Drawing.Point(10, 10);
                this.Controls.Add(vbcs);
                vbcs.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/Icons/vbcs.png");
                vbcs.Click += new System.EventHandler(this.vbcs_Click);

                //links0

                StreamReader DesktopINI = new StreamReader("C:/Black Clover/Visual Black Clover System/System Files/DesktopINI.ibc");
                RichTextBox DesktopINItext = new RichTextBox();
                DesktopINItext.Text = DesktopINI.ReadToEnd();
                DesktopINI.Close();

                //links1

                Button links1 = new Button();
                links1.Size = new System.Drawing.Size(70, 70);
                links1.Location = new System.Drawing.Point(10, 100);
                this.Controls.Add(links1);
                links1.Image = Image.FromFile(DesktopINItext.Lines[0].Substring(DesktopINItext.Lines[0].IndexOf("#") + 1));
                links1.Click += new System.EventHandler(this.links1_Click);

                //links2

                Button links2 = new Button();
                links2.Size = new System.Drawing.Size(70, 70);
                links2.Location = new System.Drawing.Point(10, 190);
                this.Controls.Add(links2);
                links2.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/Icons/calc.png");
                links2.Click += new System.EventHandler(this.links2_Click);


                //links3


                Button links3 = new Button();
                links3.Size = new System.Drawing.Size(70, 70);
                links3.Location = new System.Drawing.Point(10, 280);
                this.Controls.Add(links3);
                links3.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/Icons/browser.png");
                links3.Click += new System.EventHandler(this.links3_Click);


                //links 4


                Button links4 = new Button();
                links4.Size = new System.Drawing.Size(70, 70);
                links4.Location = new System.Drawing.Point(10, 370);
                this.Controls.Add(links4);
                links4.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/Icons/edit.png");
                links4.Click += new System.EventHandler(this.links4_Click);
            }
            catch
            {
                BlueScreen();
            }
        }


        private void vbcs_Click(object sender, EventArgs e)
        {
                VBCS_lib.VBCS_Menu menu = new VBCS_Menu();
                menu.Show();
        }


        private void links1_Click(object sender, EventArgs e)
        {
                VBCS_lib.Terminal terminal = new Terminal();
                terminal.Show();
        }

        private void links2_Click(object sender, EventArgs e)
        {
                VBCS_lib.Calculator calc = new Calculator();
                calc.Show();
        }


        private void links3_Click(object sender, EventArgs e)
        {
            VBCS_lib.BC_Browser browser = new BC_Browser("C:/Black Clover/Visual Black Clover System/System Files/BC_Search.html");
            browser.Show();
        }


        private void links4_Click(object sender, EventArgs e)
        {
            VBCS_lib.BC_Edit edit = new BC_Edit(null);
            edit.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }


        public void BlueScreen()
        {
            VBCS_lib.BlueScreen bluescreen = new BlueScreen();
            bluescreen.Show();
        }
    }
}
