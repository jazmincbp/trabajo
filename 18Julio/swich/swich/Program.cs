using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swich
{
    class Program
    {
        static void Main(string[] args)
         

        {   
            Console.Title = ("Hola");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Digite un numero");
            int valor = int.Parse(Console.ReadLine());

            switch(valor)
            {    
                case 1: Console.WriteLine("uno");
                    break;

                case 2: Console.WriteLine("dos");
                    break;

                case 3: Console.WriteLine("tres");
                    break;
                default:
                    Console.WriteLine("Se ingreso un valor fuera del campo");
                    break;
            }

            Console.ReadLine();





        }
    }
}
