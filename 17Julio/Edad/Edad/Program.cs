using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            int edad;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();



            Console.WriteLine("Digite su nombre");
            Nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("digite su Edad");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");


            }
            Console.ReadKey();
        }
    }
}
