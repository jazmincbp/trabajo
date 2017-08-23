using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_de_pares
{
    public partial class Form1 : Form
    {   //6.	Realice  un algoritmo que halle la sumatoria de los números enteros 
        //pares comprendidos entre el 1 y el 100, es decir, 2 + 4 + 6 +…. + 100.
        //El programa deberá imprimir los números en cuestión y Finalmente su sumatoria
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;

            for (int i = 0; i <=100; i=i+ 2)
            {
                suma = suma + i;
                MessageBox.Show("Numeros" + i);
            } MessageBox.Show("Sumatoria de numeros" + suma);
        }
    }
}
