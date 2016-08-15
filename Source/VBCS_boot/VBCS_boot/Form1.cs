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

namespace VBCS_boot
{
    public partial class Form1 : Form
    {
        public bool firstrun;


        public Form1()
        {
            StreamReader bootINI = new StreamReader("C:/Black Clover/Visual Black Clover System/System Files/boot.ibc");
            RichTextBox bootINItext = new RichTextBox();

            bootINItext.Text = bootINI.ReadToEnd();
            bootINI.Close();

            if (bootINItext.Lines[0] == "0")
            {
                firstrun = true;

                InitializeComponent();

                passtext.PasswordChar = '*';
                passtext.CharacterCasing = CharacterCasing.Lower;
            }
            else
            {
                firstrun = false;

                InitializeComponent();

                passtext.PasswordChar = '*';
                passtext.CharacterCasing = CharacterCasing.Lower;
                name.Visible = false;

            }
        }

        private void OK_but_Click(object sender, EventArgs e)
        {
            if(firstrun == true)
            {
                if(name.Text != "" && passtext.Text != "")
                {
                    StreamWriter userprofile = new StreamWriter("C:/Black Clover/Visual Black Clover System/System Files/boot.ibc");
                    RichTextBox userprofiletext = new RichTextBox();

                    userprofiletext.Text = null;
                    userprofiletext.AppendText("1\n");
                    userprofiletext.AppendText("1\n");
                    userprofiletext.AppendText(name.Text + "\n");
                    userprofiletext.AppendText(passtext.Text + "\n");

                    byte i = 0;
                    while(i != userprofiletext.Lines.Length)
                    {
                        userprofile.WriteLine(userprofiletext.Lines[i]);
                        i++;
                    }
                    userprofile.Close();
                    System.Diagnostics.Process.Start("C:/Black Clover/Visual Black Clover System/System Files/Visual Black Clover System.exe");
                    this.Close();
                }
                else
                {
                    ErrorText.Text = "Error. Please Write Name and password.";
                }
            }
            else
            {
                StreamReader checkpass = new StreamReader("C:/Black Clover/Visual Black Clover System/System Files/boot.ibc");
                RichTextBox pass = new RichTextBox();

                pass.Text = checkpass.ReadToEnd();
                checkpass.Close();
                if (passtext.Text == pass.Lines[3])
                {
                    System.Diagnostics.Process.Start("C:/Black Clover/Visual Black Clover System/System Files/Visual Black Clover System.exe");
                    this.Close();
                }
                else
                {
                    ErrorText.Text = "Error. Please, try again.";
                }
            }
        }

        private void passtext_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (firstrun == true)
                {
                    if (name.Text != "" && passtext.Text != "")
                    {
                        StreamWriter userprofile = new StreamWriter("C:/Black Clover/Visual Black Clover System/System Files/boot.ibc");
                        RichTextBox userprofiletext = new RichTextBox();

                        userprofiletext.Text = null;
                        userprofiletext.AppendText("1\n");
                        userprofiletext.AppendText("1\n");
                        userprofiletext.AppendText(name.Text + "\n");
                        userprofiletext.AppendText(passtext.Text + "\n");

                        byte i = 0;
                        while (i != userprofiletext.Lines.Length)
                        {
                            userprofile.WriteLine(userprofiletext.Lines[i]);
                            i++;
                        }
                        userprofile.Close();
                        System.Diagnostics.Process.Start("C:/Black Clover/Visual Black Clover System/System Files/Visual Black Clover System.exe");
                        this.Close();
                    }
                    else
                    {
                        ErrorText.Text = "Error. Please Write Name and password.";
                    }
                }
                else
                {
                    StreamReader checkpass = new StreamReader("C:/Black Clover/Visual Black Clover System/System Files/boot.ibc");
                    RichTextBox pass = new RichTextBox();

                    pass.Text = checkpass.ReadToEnd();
                    checkpass.Close();
                    if (passtext.Text == pass.Lines[3])
                    {
                        System.Diagnostics.Process.Start("C:/Black Clover/Visual Black Clover System/System Files/Visual Black Clover System.exe");
                        this.Close();
                    }
                    else
                    {
                        ErrorText.Text = "Error. Please, try again.";
                    }
                }
            }
        }
    }
}
