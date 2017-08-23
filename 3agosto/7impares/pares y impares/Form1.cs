using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pares_y_impares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //7.	Realice  un algoritmo que lea los primeros 300 números enteros y determine 
            //cuántos de ellos son Impares; al final deberá indicar su sumatoria.
            int sum = 0, cont = 0;
            string cad = "";
            for (int i = 0; i <=300; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                    cont++;
                    cad = cad + i + ",";
                   

                } 
            } MessageBox.Show("Numeros Impares: " + cad);
            MessageBox.Show("Cantidad de impares es: " +cont+"\n"+
                "Su sumatoria es: "+ sum);

        }
    }
}
