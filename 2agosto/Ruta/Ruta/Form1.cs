using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float lun, mier, vier, prom;

            lun = float.Parse(textBox1.Text);
            mier = float.Parse(textBox2.Text);
            vier = float.Parse(textBox3.Text);

            prom = (lun + mier + vier) / 3;

            MessageBox.Show("El promedio del recorrido en semana es: " + prom);

        }
    }
}
