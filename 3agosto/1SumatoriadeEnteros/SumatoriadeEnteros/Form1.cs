using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumatoriadeEnteros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0,i;

            for ( i = 1; i <=10; i++)
            {    
                suma = suma + i;
               
            }

            MessageBox.Show("La sumatoria es: " + suma);
        }
    }
}
