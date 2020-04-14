using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3SecondPart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpacityButton_Click(object sender, EventArgs e)
        {
            Opacity = Opacity == 1 ? 0.5 : 1;
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            BackColor = BackColor == Color.LightGray ? Color.Azure : Color.LightGray;
        }

        private void HelloWorldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world from home, because of quarantine :C");
        }

        private void SuperMegaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" I`m SUPERMEGABUTTON,\nand it is not variable");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button4.Click += new EventHandler(OpacityButton_Click);
            }
            else
            {
                button4.Click -= new EventHandler(OpacityButton_Click);
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button4.Click += new EventHandler(BackgroundButton_Click);
            }
            else
            {
                button4.Click -= new EventHandler(BackgroundButton_Click);
            }
                
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button4.Click += new EventHandler(HelloWorldButton_Click);
            }
            else
            {         
                button4.Click -= new EventHandler(HelloWorldButton_Click);
            }
           
        }
    }
}
 