using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que solicite la carga de numeros por teclado, obtener su promedio, finalizar la carga de valores cuando se incriba valor 0

            int suma, cant, valor, prom;
            suma = 0;
            cant = 0;
            do
            {
                Console.WriteLine("Digite un valor");
                valor = int.Parse(Console.ReadLine());

                if (valor != 0)
                {
                    suma = suma + valor;
                    cant++;
                }

            }while (valor != 0);
            if (cant!=0)
            {
                prom = suma / cant;
                Console.WriteLine("El valor de los valores ingresados es" + prom);
            }
            else
            {
                Console.WriteLine("Nose ingresaron valores");
            } 
            Console.ReadLine();

        }
    }
}
