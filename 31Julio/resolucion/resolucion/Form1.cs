using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resolucion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
          }

        private void button1_Click(object sender, EventArgs e)
        {
              if(radioButton1.Checked ==true)
            {
                Width = 600;
                Height= 400;
            }else{
                if (radioButton2.Checked == true)
                {
                    Width = 800;
                    Height = 600;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        Width = 1024;
                        Height = 768;
                    }
                }
             }     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
