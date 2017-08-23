using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    { //Carga un vector de n elementos de tipo entero ordenar posteriormente el vector
        private int[] elementos;


        public void Cargar()
        {
            Console.WriteLine("Cuantos elementos son");
            string e;
            e = Console.ReadLine();
            int n;
            n = int.Parse(e);

            elementos = new int[n];

            for (int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine("Digite los elementos");
                e = Console.ReadLine();
                elementos[i] = int.Parse(e);
            }
        }
        public void Ordenar()
        {
            for (int k = 0; k < elementos.Length; k++)
            {
                for (int i = 0; i < elementos.Length - 1 - k; i++)
                {
                    if (elementos[i] > (elementos[i + 1]))
                    {
                        int aux;
                        aux = elementos[i];
                        elementos[i] = elementos[i + 1];
                        elementos[i + 1] = aux;
                    }
                }

            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Ordenados");
            for (int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine(elementos[i]);

            } 

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Ordenar();
            p.Imprimir();
            Console.ReadLine();
        }
    }
}
