using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Vectores
    { //Realizar un programa que pida la carga de dos vectores numericos enteros de 4  elementos obtener la suma de los vectores 
        //y dicho resultado guardarlo en un3 vector del mismo tamaño sumar componenete a componente
        private  int[] vector1;
        private int[] vector2;
        private int[] vector3;

        public void Cargar(){

        vector1 = new int[4];
            
            for (int i = 0; i < 4; i++)
			{
            Console.WriteLine("Digite el valor del vector 1");
            vector1[i] = int.Parse(Console.ReadLine());
            }


        vector2 = new int[4];
            
            for (int i = 0; i < 4; i++)
			{
            Console.WriteLine("Digite el valor del vector 2 ");
            vector2[i] = int.Parse(Console.ReadLine());
            }

        }
        public void Sumatoria()
        {
           

            vector3 = new int[4];

            for (int i = 0; i < 4; i++)
            {

                vector3[i] = vector1[i] + vector2[i];
            }
            for (int i = 0; i <4; i++)
			{
			 
                Console.WriteLine("La suma es" + vector3[i]);
            }

        }

        static void Main(string[] args)
        {
            Vectores v = new Vectores();
            v.Cargar();
            v.Sumatoria();
            Console.ReadLine();
        }
    }
}
