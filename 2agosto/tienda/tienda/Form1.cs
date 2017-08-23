using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double compra;
            compra = double.Parse(textBox1.Text);

            double des = compra*15/100;
            double tc = compra - des;
            MessageBox.Show("El total de la compra es " + tc);


        }
    }
}
