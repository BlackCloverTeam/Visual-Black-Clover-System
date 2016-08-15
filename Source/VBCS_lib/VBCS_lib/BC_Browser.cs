using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace VBCS_lib
{
    public partial class BC_Browser : Form
    {
        public BC_Browser(string StartingUrl)
        {
            InitializeComponent();
            CloseBut.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/close.png");
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(StartingUrl);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Contains(".com") || textBox1.Text.Contains(".ru") || textBox1.Text.Contains(".tv") || textBox1.Text.Contains(".es"))
                {
                    webBrowser1.Navigate(textBox1.Text);
                    //webBrowser1.Document.InvokeScript(webBrowser1.Url.ToString());
                }
                else
                {
                    webBrowser1.GoSearch();
                }
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
            ((WebBrowser)sender).Url = new Uri(((WebBrowser)sender).StatusText);
            webBrowser1.Document.InvokeScript(webBrowser1.Url.ToString());
            e.Cancel = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".com") || textBox1.Text.Contains(".ru") || textBox1.Text.Contains(".tv") || textBox1.Text.Contains(".es") || textBox1.Text.Contains(".org"))
            {
                webBrowser1.Navigate(textBox1.Text);
                textBox1.Text = webBrowser1.Url.ToString();
                webBrowser1.Document.InvokeScript(webBrowser1.Url.ToString());
            }
            else
            {
                webBrowser1.GoSearch();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            textBox1.Text = webBrowser1.Url.ToString();
            webBrowser1.Document.InvokeScript(webBrowser1.Url.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            textBox1.Text = webBrowser1.Url.ToString();
            webBrowser1.Document.InvokeScript(webBrowser1.Url.ToString());
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {
            WebClient downloadfile = new WebClient();
            string DownloadUrl = webBrowser1.Url.ToString();
            downloadfile.DownloadFile(DownloadUrl, "C:/Black Clover/Visual Black Clover System/filesystem/DISK1/downloads");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
            if (textBox1.Text.Contains(".jpg") || textBox1.Text.Contains(".gif") || textBox1.Text.Contains(".jpeg") || textBox1.Text.Contains(".png") || textBox1.Text.Contains(".txt") || textBox1.Text.Contains(".mp3"))
            {
                WebClient downloadfile = new WebClient();
                string DownloadUrl = textBox1.Text;
                downloadfile.DownloadFile(DownloadUrl, "C:/Black Clover/Visual Black Clover System/filesystem/DISK1/downloads");
            }
            webBrowser1.Document.InvokeScript(webBrowser1.Url.ToString());
        }
    }
}
