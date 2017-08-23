using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public void Cargar()
        {
            Console.WriteLine("Digitar el numero");
            int num = int.Parse(Console.ReadLine());
            int suma = 0;

            suma = num  + num;
            Console.WriteLine("La suma es" + suma);

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            Console.ReadLine();
        }
    }
}
