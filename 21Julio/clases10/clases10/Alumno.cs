using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases10
{
    class Alumno
    {
        //Plantear una clase llamada alumno y definir como atributos su nombre y edad,  en el constructor realizar la carga de datos y definir otros dos metodos,
        //para imprimir los datos ingresados y un mensaje si es mayor o no de edad

        private String nombre;
        private int edad;

        public Alumno()
        {
            Console.WriteLine("Digite su nombre");
            nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite su edad");
            edad = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Su nombre es " + nombre + " \n Su edad es" + edad);
        }
        public void MM()
        {
            if (edad > 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
        }
        static void Main(string[] args)
        {

            Alumno al = new Alumno();
            al.Imprimir();
            al.MM();
            Console.ReadLine();
        }
    }

}