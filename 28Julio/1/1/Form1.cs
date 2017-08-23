﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n;
            double resultado = 0;
            n = double.Parse(textBox1.Text);
            if (n == 0)
            {
                MessageBox.Show("error ingrese un valor valido");
            }

            else
                resultado = promedio_num(n);
            MessageBox.Show("el promedio es " + resultado);

        }
        public double promedio_num(double n)
        {
            double dato, suma, prom;
            int i;
            suma = 0;
            for (i = 1; i <= n; i++)
            {
                dato = double.Parse(Interaction.InputBox("ingrese por favor un numero", "numeros", "", 0, 0));
                suma = suma + dato;
            }
            prom = suma / n;
            return prom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, resultado;
            a = int.Parse(textBox1.Text);
            resultado = sumatoria(a);
            MessageBox.Show("el resultado de la sumatoria es" + resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long a1, a;
            a = long.Parse(textBox1.Text);
            a1 = factorial(a);
            MessageBox.Show("el factorial del numero es " + a1);
        }
        public int sumatoria(int a)
        {
            int i, suma;
            suma = 0;
            for (i = 1; i <= a; i++)
            {
                suma = suma + i;

            }
            return suma;
        }

        public long factorial(long a)
        {
            long factor = 1, i, dato;
            dato = a;
            for (i = 1; i <= a; i++)
            {
                factor = factor * i;
            }
            return factor;
        }
    }
}


