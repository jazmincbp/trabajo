using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases3
{
    class Punto
    { //Desarrollar una clase que represente un punto en el plano y tenga los siguientes metodos: cargar valores de x, y, e imprimir en que cuadrante se encuentra dicho punto
        //concepto matematico 1 cuadrante si x y y son positivas, si x es -0 y Y mayor que 0

       
            private int x, y;
            
        public void Cargarvalores()
        {
            Console.WriteLine("Digite valor x");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor y");
            y = int.Parse(Console.ReadLine());
        }
        public void ImCuadrante()
        {
            if(x>0 && y>0){
                Console.WriteLine("Se encuentra en el 1 cuadrante");
            }
            else{
                if(x<0 && y>0)
                {
                    Console.WriteLine("Se encuentra en el 2 cuadrante");
                }else{
                    if(x<0 && y<0)
                    {
                        Console.WriteLine("Se encuentra en el 3 cuadrante");
                    }else{
                        if(x>0 && y<0)
                        {
                            Console.WriteLine("Se encuentra en el 4 cuadrante");
                        }
                    }
                }
            }
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            Punto pun = new Punto();
            pun.Cargarvalores();
            pun.ImCuadrante();
            
        }
    }
}
