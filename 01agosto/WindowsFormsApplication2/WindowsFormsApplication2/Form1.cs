using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked)
            {
                Text += checkBox1.Text;
            } if (checkBox2.Checked == true)
            {
                Text = Text + "Colombia";
            }
            if (checkBox3.Checked)
            {
                Text += checkBox3.Text ;
            }
            


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Text += ((CheckBox)sender).Text;
        }
    }
}
