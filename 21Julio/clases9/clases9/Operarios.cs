using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases9
{
    class Operarios
    {
        //Se desea guardar los sueldos de5 op en un vector realizar la creacion y carga del vector en el constructor

         private int[] sueldos;
        public Operarios()
        {
            sueldos = new int[5];

            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine("Ingrese el sueldo");
                sueldos[f] = int.Parse(Console.ReadLine());
            }
        }
        public void Imprimir(){
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine("Sueldo de "+sueldos[f]);
            }
           
        }

             static void Main(string[] args)
             {
                 Operarios op = new Operarios();
                 op.Imprimir();
                 Console.ReadLine();


        

        }
    }
}


