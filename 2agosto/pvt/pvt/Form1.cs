using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pvt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double presion, volumen, temperatura, masa;

            presion = double.Parse(textBox1.Text);
            volumen = double.Parse(textBox2.Text);
            temperatura = double.Parse(textBox3.Text);

            masa = (presion * volumen) / (0.37 * (temperatura + 460));

            MessageBox.Show("La masa es" + masa);

        }
    }
}
