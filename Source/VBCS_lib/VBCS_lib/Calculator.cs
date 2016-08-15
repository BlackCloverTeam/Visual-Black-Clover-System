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
    public partial class Calculator : Form
    {
        public string DO;
        public bool PathOfNum = true;
        public string num1;
        public string num2;
        public string Result;
        public bool NewNumber = true;


        public Calculator()
        {
            InitializeComponent();
            CloseBut.Image = Image.FromFile("C:/Black Clover/Visual Black Clover System/Texture/close.png");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(PathOfNum == true)
            {
                DO = "+";
                textBox1.Text = textBox1.Text + "+";
                PathOfNum = false;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (PathOfNum == true)
            {
                DO = "-";
                textBox1.Text = textBox1.Text + "-";
                PathOfNum = false;
            }
        }

        private void umn_Click(object sender, EventArgs e)
        {
            if (PathOfNum == true)
            {
                DO = "*";
                textBox1.Text = textBox1.Text + "*";
                PathOfNum = false;
            }
        }

        private void dev_Click(object sender, EventArgs e)
        {
            if (PathOfNum == true)
            {
                DO = "/";
                textBox1.Text = textBox1.Text + "/";
                PathOfNum = false;
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if(PathOfNum == true)
            {
                num1 = num1 + "1";
            }
            else
            {
                num2 = num2 + "1";
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "2";
            }
            else
            {
                num2 = num2 + "2";
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "3";
            }
            else
            {
                num2 = num2 + "3";
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "4";
            }
            else
            {
                num2 = num2 + "4";
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "5";
            }
            else
            {
                num2 = num2 + "5";
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "6";
            }
            else
            {
                num2 = num2 + "6";
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "7";
            }
            else
            {
                num2 = num2 + "7";
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "8";
            }
            else
            {
                num2 = num2 + "8";
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "9";
            }
            else
            {
                num2 = num2 + "9";
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (NewNumber == true)
            {
                textBox1.Text = null;
                NewNumber = false;
            }
            if (PathOfNum == true)
            {
                num1 = num1 + "0";
            }
            else
            {
                num2 = num2 + "0";
            }
            textBox1.Text = textBox1.Text + "0";
        }

        private void result_Click(object sender, EventArgs e)
        {
            NewNumber = true;
            if(DO == "+")
            {
                textBox1.Text = Convert.ToString(Convert.ToInt64(num1) + Convert.ToInt64(num2));
                PathOfNum = true;
                num1 = null;
                num2 = null;
            }
            else
            if(DO == "-")
            {
                textBox1.Text = Convert.ToString(Convert.ToInt64(num1) - Convert.ToInt64(num2));
                PathOfNum = true;
                num1 = null;
                num2 = null;
            }
            else
            if (DO == "*")
            {
                textBox1.Text = Convert.ToString(Convert.ToInt64(num1) * Convert.ToInt64(num2));
                PathOfNum = true;
                num1 = null;
                num2 = null;
            }
            else
            if(DO == "/")
            {
                textBox1.Text = Convert.ToString(Convert.ToInt64(num1) / Convert.ToInt64(num2));
                PathOfNum = true;
                num1 = null;
                num2 = null;
            }
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DelBut_Click(object sender, EventArgs e)
        {
            PathOfNum = true;
            num1 = null;
            num2 = null;
            textBox1.Text = null;
        }
    }
}
