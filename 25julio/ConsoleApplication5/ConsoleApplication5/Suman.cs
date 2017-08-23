using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Suman
    { //Desarrollar un programa con un vector de n elementos ingresar n por teclado luego imprimir la suma de todos sus elementos
        private int[] vector;
        private int[] vsuma;
        private int n;

        public void Cargar()
        {
            n = 0;
            vector = new int[n];
            for (int i = 0; i < n; i++){
                Console.WriteLine("Digite el valor de n");
                n = int.Parse(Console.ReadLine());
            }
        
            vsuma = new int[n];
            for (int i = 0; i < n; i++)
            {
                vsuma[i] = vsuma[i] + n;
                
            Console.WriteLine("ES" + vsuma[i]);
        }
    }


        static void Main(string[] args)
        {
            Suman s = new Suman();
            s.Cargar();
            Console.ReadLine();
        }
    }
}
