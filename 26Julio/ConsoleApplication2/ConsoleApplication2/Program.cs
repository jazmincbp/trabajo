using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private int[] vector;

        public void Cargar()
        {
            vector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite numeros");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
        public bool Verificar()
        {
            for (int i = 0; i < 9; i++)
            {


                if (vector[i] < vector[i + 1])
                {


                }
                else
                {
                    return false;
                }
               //Hecho por david cortes
            }
            return true;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Cargar();
            bool ordenados = p1.Verificar();
            if (ordenados)
            {
                Console.WriteLine("estan ordenados");
            }
            else
            {
                Console.WriteLine("estan desordenados");
            }
            Console.ReadKey();
        }
    }
}
