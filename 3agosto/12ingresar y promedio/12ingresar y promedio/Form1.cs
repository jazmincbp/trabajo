using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12ingresar_y_promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //12.	elaborar un algoritmo que solicite la cantidad 
            //de números a procesar y lea la respuesta en  n; luego 
            //que lea los n números y calcule e imprima el promedio de dichos números.

            int n,promedio, suma;
            suma=0;
            n = int.Parse(textBox1.Text);

            for (int i = 0; i < n; i++)
            {
                int numeros;
                
                numeros = int.Parse(textBox2.Text);
                suma = suma + numeros;
            }
            promedio = suma / n;
            MessageBox.Show("el promedio es: " + promedio); 
        }
    }
}
