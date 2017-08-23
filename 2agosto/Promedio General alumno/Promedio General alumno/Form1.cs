using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_General_alumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//	Examen 90%



          
           //Matematicas
            float tm1, tm2, tm3, prom, pp, exm, pexm, nm;
           //tareas
           tm1 = float.Parse(textBox1.Text);
           tm2 = float.Parse(textBox2.Text);
           tm3 = float.Parse(textBox3.Text);
            //Promedio
           prom = (tm1 + tm2 + tm3) / 3;
            pp = prom *0.10f;
            //Examen
           exm = float.Parse(textBox4.Text);
           pexm = exm *0.90f;
           nm = pp + pexm;


           
           //Fisica
           float tf1, tf2, prof, ppf, exf, pexf, nf;
           //tareas
           tf1 = float.Parse(textBox5.Text);
           tf2 = float.Parse(textBox6.Text);
           //Promedio
           prof = (tf1 + tf2 ) / 2;
           ppf = prof * 0.20f;
           //Examen
           exf = float.Parse(textBox7.Text);
           pexf = exf * 0.80f;
           nf = ppf + pexf;


           //Quimica
           float tq1, tq2, tq3, proq, ppq, exq, pexq, nq;
           //tareas
           tq1 = float.Parse(textBox8.Text);
           tq2 = float.Parse(textBox9.Text);
           tq3 = float.Parse(textBox10.Text);
           //Promedio
           proq = (tq1 + tq2 + tq3) / 3;
           ppq = proq * 0.15f;
           //Examen
           exq = float.Parse(textBox11.Text);
           pexq = exq * 0.85f;
           nq = ppq + pexq;
           float pg = (nm + nf + nq) / 3;
           MessageBox.Show("Su nota final en Matematicas es: " + nm+
                            "\nSu nota final en Fisica es: " + nf+
                            "\nSu nota final en Matematicas es: " + nq+
                            "\nSu promedio general es: " + pg
                           );

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
