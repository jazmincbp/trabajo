using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer3
{
    public partial class Form1 : Form
    {
        //Realice un algoritmo que determine el pago a realizar por la entrada a un espectáculo 
        //donde se pueden comprar sólo hasta cuatro entradas, donde al costo de dos entradas se 
        //les descuenta el 10%, al de tres entrada el 15% y a la compra de cuatro tickets se le descuenta el 20 %.


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v,b,tc,p,d;


            tc = 0;
            b = 3000;

            tc = int.Parse(textBox1.Text);

            do
	{
        switch (tc)
        {
            case 1:
                v = tc * b;
                MessageBox.Show("Valor de la boleta es: " + v);
                break;
            case 2:
                
                v = tc*b;
                d = (v * 10) / 100;
                p = v - d;


                MessageBox.Show("Valor de las 2 boletas es: " + p);
                break;
            case 3:
                 v = tc*b;
                d = (v * 10) / 100;
                p = v - d;


                MessageBox.Show("Valor de las 3 boletas es: " + p);
                break;
            case 4:
                 v = tc*b;
                d = (v * 10) / 100;
                p = v - d;
                    

                MessageBox.Show("Valor de las 4 boletas es: " + p);
                break;
            default:
                MessageBox.Show("Digite un numero valido" +
                    "\n de 1 a 4");
                break;
        }
	         
	} while (tc>5);
            
        }
    }
}
