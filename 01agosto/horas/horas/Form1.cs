using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h, ht, hx, s, ex,hte;
            ht=5000;
            hx=7000;
            h = int.Parse(textBox1.Text);
            if (h < 40)
            {
                s = h* ht;
               MessageBox.Show("Salario es" + s);
            }
            else{
            
                
                    ex =  h-40;
                    hte = ex*hx;
                    s = h*ht+hte;

                    MessageBox.Show("Salario es" + s);
                
            }
            }
        }
    }
