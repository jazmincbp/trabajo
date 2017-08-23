using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_presAnual
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
            double pres, G, P, T;

            pres = double.Parse(textBox1.Text);

            G = pres * 0.40;
            P = pres * 0.30;
            T = pres * 0.30;

            MessageBox.Show("El presupuesto para Ginecologia sera de: "+G+"$"+
                            "\nEl presupuesto para Pediatria sera de: "+P+"$"+
                            "\nEl presupuesto para Traumatologia sera de: "+T+ "$");

            
        }
    }
}
