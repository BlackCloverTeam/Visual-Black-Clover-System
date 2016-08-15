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
    public partial class BlueScreen : Form
    {
        public BlueScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
