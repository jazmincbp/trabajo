using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sueldo_vendedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sb, v1, v2, v3, sf, ex, suma;
            ex = 0.10;

            sb = 750000;
            v1 = double.Parse(textBox1.Text);
            v2 = double.Parse(textBox2.Text);
            v3 = double.Parse(textBox3.Text);

            suma = v1 + v2 + v3;
            double comision = suma * ex;
            sf = comision + sb;

            MessageBox.Show(" Su sueldo base es" + sb + "\n El total de sus ventas mas comision es" + comision + " su sueldo total es" + sf);
        }
    }
}
