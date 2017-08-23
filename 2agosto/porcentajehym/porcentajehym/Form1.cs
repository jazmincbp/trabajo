using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porcentajehym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float h, m, personas;

            h = float.Parse(textBox1.Text);
            m = float.Parse(textBox2.Text);
            personas = h + m;
            float p1 = h * 100 / personas;
            float p2 = m * 100 / personas;

            MessageBox.Show("Porcentaje de hombres "+p1+
                            "\n Porcentaje de mujeres "+p2);
        }
    }
}
