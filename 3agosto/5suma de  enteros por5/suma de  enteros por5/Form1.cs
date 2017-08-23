using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_de__enteros_por5
{
    public partial class Form1 : Form
    {//5.	Realice  un algoritmo que halle  la sumatoria de los números enteros múltiplos de 5, 
        //comprendidos entre el 1 y el 100, es decir, 5 + 10 + 15 +…. + 100. El programa deberá 
        //imprimir los números en cuestión y finalmente su sumatoria
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            sum = 0;
            
            for (int i = 0; i <=100; i = i + 5)
            {

                sum = sum + i;
                MessageBox.Show("Numeros: " + i);
            }
           
            MessageBox.Show("Sumatoria de numeros: " + sum);
        }
    }
}
