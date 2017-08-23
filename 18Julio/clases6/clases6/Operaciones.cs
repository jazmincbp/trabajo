using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases6
{
    class Operaciones
    { //Realizar un ejercicio con clases y metodos donde en cada metodo pueda generar una operacion matematica(suma, resta, multiplicacion, division) de dos valores

        private float v1, v2, s,r,m,d;

        public void Ingresar()
    {
        Console.WriteLine("Ingresar valor 1");
        v1= float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar valor 2");
        v2= float.Parse(Console.ReadLine());
       }

    public void Suma()
    {   
        s =v1+v2;
        Console.WriteLine("La suma es"+s);
    }
        public void Resta()
    {   
        r =v1-v2;
        Console.WriteLine("La resta es"+r);
        }
        public void Multiplicacion()
    {   
        m =v1*v2;
        Console.WriteLine("La multiplicacion es"+m);
        }
        public void Division()
    {   
        d =v1/v2;
        Console.WriteLine("La division es"+d);
        }

        static void Main(string[] args)
        {
            Operaciones oper = new Operaciones();
            oper.Ingresar();
            oper.Suma();
            oper.Resta();
            oper.Multiplicacion();
            oper.Division();
            Console.ReadLine();
        }
    }
}
