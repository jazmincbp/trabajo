using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ganancia_del_producto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio, gan, valor;

            precio = double.Parse(textBox1.Text);
            gan = precio * 0.30;
            valor = precio + gan;

            MessageBox.Show("El nuevo precio del producto es " + valor);
        }
    }
}
