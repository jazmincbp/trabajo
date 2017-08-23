using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//11.	elaborar un algoritmo que lea 20 números y que 
            //calcule e imprima el promedio de dichos números.
            int n, t;
            n = int.Parse(textBox1.Text);
            for (int i = 0; i < 20; i++)
            {
                t= (n * i) / 20;
                MessageBox.Show("el promedio es" + t);
            }
            
        }
    }
}
