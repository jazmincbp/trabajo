using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_de_fraccionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //10.	elabore un algoritmo que calcule
            //e imprima la suma 1+1/2+1/3+1/4……1/50.
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           float suma;
            
            suma = 0;
            for (float i = 1; i <49; i++)
            {
                suma = suma + (1 / i);
                MessageBox.Show("Los numeros son: " + suma);
            } MessageBox.Show("La sumatoria es: " + suma);
        }
    }
}
