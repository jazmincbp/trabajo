using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases2
{
    class Triangulo
    {
        //desarrollar un programa que carge los lados de un tri e implemente los siguientes metodos  inicializar, imprimir, donde imprima el
            //valor del lado mayor y otro metodo imprimir donde muestre ei el triangulo es equilatero o no.

        private int l1, l2, l3;

        public void Inicializar()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Green;
     
        Console.Clear();

        Console.WriteLine("Digite lado 1");
        l1 = int.Parse(Console.ReadLine());

         Console.WriteLine("Digite lado 2");
        l2 = int.Parse(Console.ReadLine());

         Console.WriteLine("Digite lado 3");
        l3 = int.Parse(Console.ReadLine());
        }
        public void LadoMayor()
        {
            Console.WriteLine("Lado Mayor");
            if(l1>l2 && l1>l3)
            {
                Console.WriteLine(""+l1);
            }
            else{
                if (l2>l3)
                {
                    Console.WriteLine(""+l2);
                }
                else{
                    Console.WriteLine(""+l3);
                }
            }
        }
        public void EsEquilatero()
        {
            if (l1 == l2 && l1 == l3)
            {
                Console.WriteLine("Sus lados son iguales");
            }
            else
            {
                Console.WriteLine("No es un triangulo equilatero");
            }
        }
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            tri.Inicializar();
            tri.LadoMayor();
            tri.EsEquilatero();
            Console.ReadLine();
        }
        
    }
}
