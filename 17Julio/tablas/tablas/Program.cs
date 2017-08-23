using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            float a, x;

            Console.WriteLine("Digite un numero");
            a = float.Parse(Console.ReadLine());

            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("ES");

            }
            Console.ReadKey();
        }
    }
}
