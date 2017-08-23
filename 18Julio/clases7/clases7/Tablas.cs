using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases7
{
    class Tablas
    {//Realizar las tablas de multiplicar utilizando sos metodos cargar valor y metodo de realizar la operacion utilizando el do while
        private float n, i, r;
        public void Ingresar()
        {
            Console.WriteLine("Digite el valor");
            n = float.Parse(Console.ReadLine());
        }
        public void Tabla()
        {
            do{
                Ingresar();
                for (i = 0; i<=10; i++){
         
                       r = i * n;
                       Console.WriteLine(+n+ "*" + i + "=" +r);
                   
                }
                
            } while (n != 0 );
        }

        static void Main(string[] args)
        {
            Tablas tab = new Tablas();
            tab.Tabla();
            Console.ReadLine();

        }
    }
}
