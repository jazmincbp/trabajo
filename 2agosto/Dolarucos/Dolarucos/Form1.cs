using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolarucos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pes, dol;
            dol = 2995;

            pes = float.Parse(textBox1.Text);

            float conv = pes/dol;
            MessageBox.Show("Su cantidad en dolares es " + conv);
        }
    }
}
