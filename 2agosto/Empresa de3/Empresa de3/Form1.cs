using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_de3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m1, m2, m3;

            m1 = int.Parse(textBox1.Text);
            m2 = int.Parse(textBox2.Text);
            m3 = int.Parse(textBox3.Text);

            int total = m1 + m2 + m3;

            int p1 = m1* 100/total;
            int p2 = m2 * 100/total;
            int p3 = m3 * 100/total;

            MessageBox.Show("El porcentaje de la persona 1 es: "+ p1 + "%" +
                          "\nEl porcentaje de la persona 2 es: " + p2 + "%" +
                          "\nEl porcentaje de la persona 3 es: " + p3 + "%");
        }
    }
}
