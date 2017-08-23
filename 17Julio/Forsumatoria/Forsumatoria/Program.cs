using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            float x, suma;
            suma = 0;

            Console.Title = "Primer programa";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            for (x = 1; x <= 10; x++)
            {
                suma = suma + x;
                Console.WriteLine("El resultado es" + x);
            }

            Console.WriteLine("El resultado de la suma es" + suma);

            Console.ReadKey();




        }
    }
}
