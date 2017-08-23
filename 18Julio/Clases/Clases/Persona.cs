using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Persona
    {
       
        //realizar una clase que permita la carga del nombre y la edad de una persona, mostrar los datos cargados e imprimir un mensaje si es mayor de edad

        private string  nombre;
        private int edad;

            public void Inicializar()
            {
                Console.WriteLine("Digite el nombre");
                nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite la edad");
                edad = int.Parse(Console.ReadLine());
            }
        public void Imprimir()
        {
            Console.WriteLine("nombre" + nombre+"\n");
            Console.WriteLine("edad" + edad + "\n");
        }
        public void MayordeEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad\n");
            }
            else
            {
                Console.WriteLine("Es menor de edad\n");
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.MayordeEdad();

        }
    }
}
