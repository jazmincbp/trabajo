using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero en letras");
            String numero = Console.ReadLine();

            switch (numero)
            {
                case "uno": Console.WriteLine(1);
                    break;

                case "dos": Console.WriteLine(2);
                    break;

                case "tres": Console.WriteLine(3);
                    break;

                case "cuatro": Console.WriteLine(4);
                    break;

                default:
                    Console.WriteLine("Se ingreso un campo mayor a cuatro");
                    break;

            }
            Console.ReadLine();


        }
    }
}
