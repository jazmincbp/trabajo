using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases5
{
    class Empleado
    {
        private string nombre; 
        private int sueldo;

        public void CargarDatos()
    {
        Console.WriteLine("Digite su nombre");
        nombre = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Digite su sueldo");
        sueldo = int.Parse(Console.ReadLine());
        }
        public void ImDatos()
        {
            Console.WriteLine("Nombre"+nombre+"\n");
            Console.WriteLine("Su Sueldo" + sueldo+"\n");
        }
        public void ImSueldo()
        {
            if (sueldo > 800000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }

       static void Main(string[] args)
       {
           Empleado em = new Empleado();
           em.CargarDatos();
           em.ImDatos();
           em.ImSueldo();
           Console.ReadLine();
           
        //Realizar una clase que represente un empleado definir como atributos su nombre y su sueldo, metodos de carga otro para
            //imprimir sus datos y por ultimo uno que imprima un mensaje si debe pagar impuestos ( si el sueldo supera los 800000)
        }
    }
}
