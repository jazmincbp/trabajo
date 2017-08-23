using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeros_pares_sumatoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //9.	elaborar un algoritmo que calcule e imprima la suma de los números pares del 2 hasta el 160.
            int cont=0;
            string c = "";

            for (int i = 0; i <=160; i= i+2)
            {
               
                cont++;
                c = c + i+",";
               
            } MessageBox.Show("Los numeros pares son: " + c);
            MessageBox.Show("Cantidad de numeros pares: "+cont);
        }
    }
}
