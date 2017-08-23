using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
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
            float cal1, cal2, cal3, exf, trf, pro,p1,p2,p3, final;

            cal1 = float.Parse(textBox1.Text);
            cal2 = float.Parse(textBox2.Text);
            cal3 = float.Parse(textBox3.Text);
            exf = float.Parse(textBox4.Text);
            trf = float.Parse(textBox5.Text);

             pro = (cal1 + cal2 + cal3) / 3;
             p1 = pro * 0.55f;
             p2 = exf * 0.30f;
             p3 = trf * 0.15f;
            final = p1 + p2 + p3;

            MessageBox.Show("El porcentaje de las calificaciones es" + p1+
                             "\n El porcentaje de lexamenfinal es"+p2+
                             "\n El porcentaje del trabajofinal es"+p3+
                              "\n Su nota final es"+final);

                
        }
    }
}
