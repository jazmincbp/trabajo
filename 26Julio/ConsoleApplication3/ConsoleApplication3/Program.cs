using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    { //Realizar un programa que permita carga los nombres de 5 operarios y sus sueldos respectivos mostrar su sueldo mayor y el nombre del operario
        private string[] nombre;
        private float[] sueldo;

        public void Cargar()
        {


            nombre = new string[5];
            sueldo = new float[5];
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Digite su nombre");
                nombre[i] =Console.ReadLine();
                Console.WriteLine("Digite su sueldo");
                sueldo[i] = float.Parse(Console.ReadLine());
            }

        }
        public void SueldoMayor()
        {
            float mayor = 0;
            int pos;
            mayor = sueldo[0];
            pos = 0;

            for (int i = 1; i < nombre.Length; i++)
            {
                    if (sueldo[i] > mayor)
                    {
                        mayor = sueldo[i];
                        pos = i;
                    }
                }
                Console.WriteLine("El empleado con mayor sueldop es" + nombre[pos]);
                Console.WriteLine("El mayor sueldo es" + mayor);
            }
        



           

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.SueldoMayor();
            Console.ReadLine();
        }
    }
}
