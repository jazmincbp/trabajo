using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0, suma;
            suma = 0;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            while (x < 10)
            {
                x = x + 1;
                suma = suma + x;

                Console.WriteLine("los numeros son" + x);
            }
            Console.WriteLine("la sumatoria es" + suma);
            Console.ReadKey();

        }
    }
}
