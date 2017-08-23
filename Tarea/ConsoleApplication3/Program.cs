using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Program
    {
        private String nombre;
        private int nmat, prom, costm, iva, col, tp;

        public Program()
        {

            Console.WriteLine("Digite su nombre");
            nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite el numero de materias que cursa");
            nmat = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite su ultimo promedio obtenido");
            prom = int.Parse(Console.ReadLine());

            iva = 19;
            costm = 10000;
        }
        public void MayorMenor()
        {

            col = nmat * costm;

            if (prom > 9)
            {
                tp = col + (iva * 10 / 100);
                Console.WriteLine("El costo total a pagar de la colegiatura es" + tp);
            }
            else
            {
                tp = col - (col * 30 / 100);
                Console.WriteLine("El costo total a pagar de la colegiatura es" + tp);
            }
        }

        public static void Main(string[] args)
        {
            Program colg = new Program();
            colg.MayorMenor();
            Console.ReadLine();
        }
    }
}