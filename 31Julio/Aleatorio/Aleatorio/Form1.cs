using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aleatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("Felicidades, adivina el numero, Enhora buena:");
            }
            else
                MessageBox.Show("Lo siento su numero no es correcto, intentelo de nuevo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random n = new Random();
            int textBox1 = n.Next(1, 10);
            textBox2.Text = Convert.ToString(textBox1);
        }
    }
}
