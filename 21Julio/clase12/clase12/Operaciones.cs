using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase12
{
    class Operaciones
    {
        //clases operaciones se deben cargar 2 valores enteros constructo, calcualar su suma, resta, multiplicacion y division cada una en un metodo e imprimir dicho resultado

        private int valor1;
        private int valor2;

        public Operaciones(){
            Console.WriteLine("Digite valor 1");
            valor1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 2");
            valor2 =int.Parse(Console.ReadLine());
        }
        public void Suma(){
            int s = valor1 + valor2;
            Console.WriteLine("Suma"+s);
        }
         public void Resta(){
            int r = valor1 - valor2;
            Console.WriteLine("Resta"+r);

        }
         public void Multiplicacion(){
            int m = valor1 * valor2;
            Console.WriteLine("Multiplicacion"+m);

        }
         public void Division(){
            int d = valor1 / valor2;
            Console.WriteLine("Division"+d);

        }
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Suma();
            op.Resta();
            op.Multiplicacion();
            op.Division();
            Console.ReadLine();

        }
    
    }
}
