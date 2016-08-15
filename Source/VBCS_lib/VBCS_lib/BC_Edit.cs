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

namespace VBCS_lib
{
    public partial class BC_Edit : Form
    {
        public string RealPath;
        public string FilePath;
        public string CurrentPath;
        public bool ExCurrentFile = false;


        public BC_Edit(string CurrentFile)
        {
            if (CurrentFile == null || CurrentFile == "")
            {
                
            }
            else
            {
                ExCurrentFile = true;
            }
            InitializeComponent();
            COMPILE.Visible = false;
            //if (CurrentFile.Contains(".jin"))
            //{
            //    COMPILE.Visible = true;
            //}
            CloseBut.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/close.png");
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if(ExCurrentFile == true)
            {
                StreamWriter savetext = new StreamWriter(RealPath);
                savetext.WriteLine(richTextBox1.Text);
                savetext.Close();
            }
            else
            {
                FileWindow filewindow = new FileWindow(richTextBox1);
                filewindow.Show();
            }
        }

        private void COMPILE_Click(object sender, EventArgs e)
        {
            RichTextBox code = new RichTextBox();
            StreamReader readcode = new StreamReader(CurrentPath);
            code.Text = readcode.ReadToEnd();
            readcode.Close();
            
        }
    }
}
