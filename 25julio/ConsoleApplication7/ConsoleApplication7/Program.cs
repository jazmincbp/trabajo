using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    { 
        //Se tienen las notas del primer parcial de los alumnos de dos cursos el curso a y el curso b 
       //cada curso cuenta con 5 alumnos realizar un programa que muestre el curso que obtuvo el mayor promedio general

        private int[] cursoa;
        private int[] cursob;

        public void CargarDatos()
        {

            cursoa = new int[5];
            Console.WriteLine("Digita las notas del curso A");
            for (int i = 0; i < 5; i++)
            { 
                cursoa[i] = int.Parse(Console.ReadLine());
            }
            cursob = new int[5];
            Console.WriteLine("Digita las notas del curso B");
            for (int i = 0; i < 5; i++)
            {
                cursob[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Promedio()
        {
            int suma1 = 0;
            int suma2 = 0;
            for (int i = 0; i < 5; i++)
            {
                suma1 = suma1 + cursoa[i] / cursoa[i];
                suma2 = suma2 + cursob[i] / cursob[i];

            }
            int promedioa = suma1 / 5;
            int promediob = suma2 / 5;


            if (promedioa > promediob)
            {
                Console.WriteLine("El promedio del cursoA es mayor");
            }
            else
            {
                Console.WriteLine("El promedio del cursoB es menor");
            }
        }
     static void Main(string[] args)
        {
            Program p = new Program();
            p.CargarDatos();
            p.Promedio();
            Console.ReadLine();
        }
    }
}
