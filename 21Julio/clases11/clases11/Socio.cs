using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases11
{
    class Socio
    {
        //Plantear una clase  club y otra socio la clase socio debe tener los siguientes atributos privados:nombre y la antigùedad en el club en años
        //En el constructor pedir la carga del nombre y su antiguedad. La clase club debe tener como atributos 3 objetos de la clase definir una 
        //responsabilidad para imprimir el nombre del socio con mayor antiguedad en el club

        private String nombre;
        private int ant;

        public Socio()
        {
            Console.WriteLine("Ingrese Nombre");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese Antiguedad");
            ant = int.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine("Su nombre es" + nombre + "\n Su antiguedad es" + ant);
        }
        public int RetAnt()
        {
            return ant;
        }

        class Club
        {

            private Socio s1, s2, s3;
            public Club()
            {

                s1 = new Socio();
                s2 = new Socio();
                s3 = new Socio();
            }

            public void MayorAnt()
            {
                Console.WriteLine("Socio con mayor antiguedad");
                if (s1.RetAnt() > s2.RetAnt() && s1.RetAnt() > s2.RetAnt())
                {
                    s1.Imprimir();
                }
                else
                {
                    if (s2.RetAnt() > s3.RetAnt())
                    {
                        s2.Imprimir();
                    }
                    else
                    {
                        s3.Imprimir();
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            Socio so = new Socio();
            so.Imprimir();


            Club c = new Club();
            c.MayorAnt();
        }
        
    }
}
    
