using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases13
{

    public class Vector
    {
        //Definir un vector de 5  componenetes de tipo float que rep`resenten las alturas de 5 personas obtener el promedio de las misma y contar cuantas personas son mas altas del p y cuantas mas bajas-
        //utilizar clases y metodos para el ejercicio

        private float[] altura;
        private float promedio;


        public void Cargar()
        {

            altura = new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("Digite la altura de la persona");
                altura[f] = float.Parse(Console.ReadLine());
            }

        }
        public void CalcularPromedio()
        {
            float suma;
            suma = 0;
            for (int f = 0; f < 5; f++)
            {
                suma = suma + altura[f];
            }
            promedio = suma / 5;
            Console.WriteLine("Promedio de alturas" + promedio);
        }
        public void MayorMenor()
        {

            int may, men;
            may = 0;
            men = 0;
            for (int f = 0; f < 5; f++)
            {
                if (altura[f] > promedio)
                {
                    may = may + 1;
                }
                else
                {
                    if (altura[f] < promedio)
                    {
                        men = men + 1;
                    }
                }
            }
            Console.WriteLine("Promedio de personas altas" + may);
            Console.WriteLine("Promedio de personas bajas" + men);
        }

        public static void Main(string[] args)
        {
            Vector v = new Vector();
            v.Cargar();
            v.CalcularPromedio();
            v.MayorMenor();
            Console.ReadLine();

        }
    }
}