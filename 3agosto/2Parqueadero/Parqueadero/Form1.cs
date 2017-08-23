using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float he = 0, hs = 0, ht,suma=0,p;

            he = float.Parse(textBox1.Text);
            hs = float.Parse(textBox2.Text);
            
            ht = hs - he;
            if (ht>1)
            {
                for (float i = 1; i <ht; i++)
                {
                    ht =ht +600;
                }
                p = suma + 1000;
                
                MessageBox.Show("" + p);
            }
            else
            {
                p = ht * 1000;
                MessageBox.Show("" + p);
            }
           
            
        }
    }
}
