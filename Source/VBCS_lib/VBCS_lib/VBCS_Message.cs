using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBCS_lib
{
    public partial class VBCS_Message : Form
    {


        public VBCS_Message(string MessageText)
        {
            InitializeComponent();
            Messagetext.Text = MessageText;
            CloseBut.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/close.png");
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
