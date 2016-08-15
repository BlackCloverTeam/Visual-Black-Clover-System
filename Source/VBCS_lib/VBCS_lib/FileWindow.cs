﻿using System;
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
    public partial class FileWindow : Form
    {
        public string RealPath = "C:/Black Clover/Visual Black Clover System/filesystem/DISK1";
        public string VBCS_Path = ">";
        public int dirl;
        public string COM;
        public Button[] dir = new Button[10];
        public bool FileMode = false;
        public RichTextBox WriteDialogFile;


        public FileWindow(RichTextBox WriteDialogFileR)
        {
            MessageBox.Show(WriteDialogFileR.Text);
            WriteDialogFile.Text = WriteDialogFileR.Text;
            try
            {
                InitializeComponent();
                CloseBut.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/close.png");
                byte i = 0;
                Point[] points = new Point[dir.Length];
                int pointx = 20; int pointy = 45;
                while (i != 10)
                {
                    dir[i] = new Button();
                    points[i] = new Point(pointx, pointy);
                    dir[i].Location = points[i];
                    dir[i].Width = 450;
                    dir[i].Height = 25;
                    this.Controls.Add(dir[i]);
                    pointy = pointy + 25;
                    dir[i].Visible = false;
                    i++;
                }
                dir[0].Click += new System.EventHandler(this.dir1_Click);
                dir[1].Click += new System.EventHandler(this.dir2_Click);
                dir[2].Click += new System.EventHandler(this.dir3_Click);
                dir[3].Click += new System.EventHandler(this.dir4_Click);
                dir[4].Click += new System.EventHandler(this.dir5_Click);
                dir[5].Click += new System.EventHandler(this.dir6_Click);
                dir[6].Click += new System.EventHandler(this.dir7_Click);
                dir[7].Click += new System.EventHandler(this.dir8_Click);
                dir[8].Click += new System.EventHandler(this.dir9_Click);
                dir[9].Click += new System.EventHandler(this.dir10_Click);
                i++;
                RenderCurrentDirectory(RealPath);
            }
            catch
            {
                BlueScreen bluescreen = new BlueScreen();
                bluescreen.Show();
            }
        }


        public void RenderCurrentDirectory(string rcdPath)
        {
            try 
            { 
            string[] FilesDir;
            if(FileMode == false)
            {
                FilesDir = Directory.GetDirectories(rcdPath);
            }
            else
            {
                FilesDir = Directory.GetFiles(rcdPath);
            }
            int i = 0;
            if (FilesDir.Length < dirl)
            {
                while(i != 10)
                {
                    dir[i].Visible = false;
                    i++;
                }
            }
            dirl = FilesDir.Length;
            i = 0;
            while(i != dirl)
            {
                dir[i].Visible = true;
                dir[i].Text = FilesDir[i].Substring(RealPath.Length + 1);
                i++;
            }
            }
            catch
            {
                BlueScreen bluescreen = new BlueScreen();
                bluescreen.Show();
            }
        }


        private void dir1_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[0].Text;
                VBCS_Path = VBCS_Path + ">" + dir[0].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                StreamWriter writesavetext = new StreamWriter(RealPath + "/" + dir[0].Text);
                long i = 0;
                while(i != WriteDialogFile.Lines.Length)
                {
                    writesavetext.WriteLine(WriteDialogFile.Lines[i] + "\n");
                    i++;
                }
                writesavetext.Close();
            }
        }


        private void dir2_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[1].Text;
                VBCS_Path = VBCS_Path + ">" + dir[1].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[1].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                //edit.label1.Text = timepath;
                edit.Show();
            }
        }


        private void dir3_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[2].Text;
                VBCS_Path = VBCS_Path + ">" + dir[2].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[2].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                edit.RealPath = timepath;
                edit.FilePath = VBCS_Path;
                edit.Show();
            }
        }


        private void dir4_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[3].Text;
                VBCS_Path = VBCS_Path + ">" + dir[3].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[3].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                edit.RealPath = timepath;
                edit.FilePath = VBCS_Path;
                edit.Show();
            }
        }


        private void dir5_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[4].Text;
                VBCS_Path = VBCS_Path + ">" + dir[4].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[4].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                edit.RealPath = timepath;
                edit.FilePath = VBCS_Path;
                edit.Show();
            }
        }


        private void dir6_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[5].Text;
                VBCS_Path = VBCS_Path + ">" + dir[5].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[5].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                edit.RealPath = timepath;
                edit.FilePath = VBCS_Path;
                edit.Show();
            }
        }


        private void dir7_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[6].Text;
                VBCS_Path = VBCS_Path + ">" + dir[6].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[6].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                edit.RealPath = timepath;
                edit.FilePath = VBCS_Path;
                edit.Show();
            }
        }


        private void dir8_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[7].Text;
                VBCS_Path = VBCS_Path + ">" + dir[7].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[7].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                edit.RealPath = timepath;
                edit.FilePath = VBCS_Path;
                edit.Show();
            }
        }


        private void dir9_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[8].Text;
                VBCS_Path = VBCS_Path + ">" + dir[8].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[8].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                edit.RealPath = timepath;
                edit.FilePath = VBCS_Path;
                edit.Show();
            }
        }


        private void dir10_Click(object sender, EventArgs e)
        {
            if (FileMode == false)
            {
                RealPath = RealPath + "/" + dir[9].Text;
                VBCS_Path = VBCS_Path + ">" + dir[9].Text;
                RenderCurrentDirectory(RealPath);
            }
            else
            {
                string timepath = RealPath + "/" + dir[9].Text;
                StreamReader readfile = new StreamReader(timepath);
                BC_Edit edit = new BC_Edit(timepath);
                edit.richTextBox1.Text = readfile.ReadToEnd();
                readfile.Close();
                edit.RealPath = timepath;
                edit.FilePath = VBCS_Path;
                edit.Show();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filebut_Click(object sender, EventArgs e)
        {

        }
    }
}