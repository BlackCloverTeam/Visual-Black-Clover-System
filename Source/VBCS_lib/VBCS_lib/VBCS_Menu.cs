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
    public partial class VBCS_Menu : Form
    {
        public VBCS_Menu()
        {
            InitializeComponent();
            CloseBut.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/close.png");
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FILESYSTEM_Click(object sender, EventArgs e)
        {
            VBCS_File filesystem = new VBCS_File();
            filesystem.Show();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SETTINGS_Click(object sender, EventArgs e)
        {
            VBCS_lib.VBCS_Message mes = new VBCS_Message("now not work");
            mes.Show();
        }

        private void MANUAL_Click(object sender, EventArgs e)
        {
            VBCS_lib.VBCS_Message mes = new VBCS_Message("now not work");
            mes.Show();
        }
    }
}
