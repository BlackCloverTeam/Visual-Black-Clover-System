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
    public partial class Terminal : Form
    {
        public static string COM;
        public static long NowLine = 0;
        public static string RealPath = "C:/Black Clover/Visual Black Clover System/filesystem/DISK1/";
        public static string TermPath = ">";
        public static string UserName;
        public static string[] ConsoleVariableName = new string[100000];
        public static string[] ConsoleVariable = new string[100000];
        public static int ConsoleVariableCount = 0;



        public Terminal()
        {
            StreamReader readusername = new StreamReader("C:/Black Clover/Visual Black Clover System/System Files/boot.ibc");
            RichTextBox userprofile = new RichTextBox();
            userprofile.Text = readusername.ReadToEnd();
            readusername.Close();
            UserName = userprofile.Lines[2];
            InitializeComponent();
            CloseBut.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/close.png");
            TermWrite("   --- Visual Black Clover System Terminal ---");
            TermWrite("   --- Black Clover Copyright 2014-2016 ---");
            TermWrite("");
            TermWrite("");
        }


        private void Console_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    COM = Console.Lines[NowLine];
                    DoCOM();
                    NowLine++;
                }
                catch(Exception ex)
                {
                    NowLine = 0;
                    TermPath = ">";
                    RealPath = "C:/Black Clover/Visual Black Clover System/filesystem/DISK1/";
                    Console.Text = null;
                    TermWrite("   --- Visual Black Clover System Terminal ---");
                    TermWrite("   --- Black Clover Copyright 2014-2015 ---");
                    TermWrite("");
                    TermWrite("ERROR: " + ex.Message);
                    TermWrite("");
                    NowLine++;
                }
            }
        }


        public void DoCOM()
        {
            if(COM.Contains("echo"))
            {
                if (COM.Contains("#"))
                {
                    string VariableText = COM.Substring(COM.IndexOf("#") + 1);
                    //TermWrite(VariableText);
                    int i = 0;
                    while (i != ConsoleVariableCount)
                    {
                        if (ConsoleVariableName[i] == VariableText)
                        {
                            TermWrite(ConsoleVariable[i]);
                            i = ConsoleVariableCount - 1;
                        }
                        i++;
                    }
                }
                else
                {
                     TermWrite(COM.Substring(5));
                }
            }
            else
            if(COM == "pwd")
            {
                TermWrite(TermPath);
            }
            else
            if(COM == "ls")
            {
                int i = 0;
                string[] LSd = Directory.GetDirectories(RealPath);
                string[] LSf = Directory.GetFiles(RealPath);
                while(i != LSd.Length)
                {
                    TermWrite("    " + LSd[i].Substring(RealPath.Length));
                    i++;
                }
                i = 0;
                while (i != LSf.Length)
                {
                    TermWrite("    " + LSf[i].Substring(RealPath.Length));
                    i++;
                }
            }
            else
            if(COM.Contains("cd"))
            {
                string NewPath = COM.Substring(3);
                if(NewPath == ">")
                {
                       RealPath = "C:/Black Clover/Visual Black Clover System/filesystem/DISK1/";
                       TermPath = ">";
                }
                else
                {
                    string[] EXD = Directory.GetDirectories(RealPath);
                    int i = 0;
                    bool found = false;
                    while (i != EXD.Length)
                    {
                        if (EXD[i].Substring(RealPath.Length) == NewPath)
                        {
                            found = true;
                            RealPath = RealPath + NewPath + "/";
                            TermPath = TermPath + NewPath + ">";
                        }
                        i++;
                    }
                    if(found == false)
                    {
                        TermWrite("'" + NewPath + "'" + " not found.");
                    }
                }
            }
            else
            if(COM.Contains("mkdir"))
            {
                if(COM.Contains("."))
                {
                    File.Create(RealPath + COM.Substring(6));
                }
                else
                {
                    Directory.CreateDirectory(RealPath + COM.Substring(6));
                }
            }
            else
            if (COM.Contains("cls"))
            {
                NowLine = 0;
                Console.Text = null;
            }
            else
            if(COM.Contains("cat"))
            {
                StreamReader readcattext = new StreamReader(RealPath + COM.Substring(4));
                RichTextBox printtext = new RichTextBox();
                printtext.Text = readcattext.ReadToEnd();
                readcattext.Close();
                int i = 0;
                while(i != printtext.Lines.Length)
                {
                    TermWrite(printtext.Lines[i]);
                    i++;
                }
            }
            else
            if (COM.Contains("#set"))
            {
                string CurrentVariable = COM.Substring(4).Remove(COM.Substring(4).IndexOf(" "));
                 int i = 0;
                 bool right = false;
                 while (i != ConsoleVariableCount)
                 {
                     if (ConsoleVariableName[i] == CurrentVariable)
                     {
                          ConsoleVariable[i] = COM.Substring(COM.IndexOf(" ") + 1);
                          //TermWrite(ConsoleVariable[i]);
                          //TermWrite(Convert.ToString(COM.IndexOf(" ")));
                          //TermWrite(Convert.ToString(i));
                          right = true;
                          i = ConsoleVariableCount - 1;
                     }
                     i++;
                 }
                if(right == false)
                {
                    TermWrite("ERROR: Sorry, but '" + CurrentVariable + "' does not exist.");
                }
            }
            else
            if (COM.Contains("set"))
            {
                ConsoleVariableName[ConsoleVariableCount] = COM.Substring(4);
                //byte i = 0;
                //while(i != ConsoleVariableCount)
                //{
                //    TermWrite(ConsoleVariableName[i]);
                //    i++;
                //}
                ConsoleVariableCount++;
            }
            else
            if (COM.Contains("help"))
            {
                TermWrite("---------");
                TermWrite("echo (#)[...] - Prints a message or variable on the screen.");
                TermWrite(" ");
                TermWrite("pwd - Prints the current path.");
                TermWrite(" ");
                TermWrite("ls - Displays the contents of the current path.");
                TermWrite(" ");
                TermWrite("cd [...] - Goes to the selected folder.");
                TermWrite(" ");
                TermWrite("mkdir [...] - Creates a new folder.");
                TermWrite(" ");
                TermWrite("cls - Clear the screen.");
                TermWrite(" ");
                TermWrite("mkdir [...] - Creates a new folder.");
                TermWrite(" ");
                TermWrite("cat [...] - Displays text from a file.");
                TermWrite(" ");
                TermWrite("help [...] - Displays informations about any commands.");
                TermWrite(" ");
                TermWrite("(#)set [...] - Create new variable or sets the value of current variable.");
                TermWrite("---------");
            }
            else
            if(COM == "calc")
            {
                Calculator calc = new Calculator();
                calc.Show();
            }
            else
            {
                TermWrite("");
                TermWrite(" Error: '" + COM + "' not found.");
                TermWrite("");
            }
            TermWrite(UserName + "$>");
        }


        public void TermWrite(string TEXT)
        {
            try
            {
                Console.AppendText("\n" + TEXT);
                NowLine++;
            }
            catch
            {
                NowLine = 0;
                TermPath = "[DISK1]>";
                RealPath = "C:/Black Clover/Visual Black Clover System/filesystem/DISK1/";
                Console.Text = null;
                TermWrite("   --- Visual Black Clover System Terminal ---");
                TermWrite("   --- Black Clover Copyright 2014-2016 ---");
                TermWrite("");
                TermWrite("");
            }
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
