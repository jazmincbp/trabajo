using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  salario, nsal;

            salario = double.Parse(textBox1.Text);

            double incre = salario*0.25;

            nsal = salario + incre;

            MessageBox.Show("Su nuevo salario es: "+nsal);
        }
    }
}
