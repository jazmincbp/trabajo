using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases4
{
    class Cuadrado
    { //Realizar una clase que represente un cuadrado y tenga los siguientes metodos
        //cargar el valor de su lado, imprimir su perimetro y su superficie.
        private int l, per, sup;
 
        public void CargarValores()
        {
            Console.WriteLine("Digite el lado ");
            l = int.Parse(Console.ReadLine());
        }
        public void Perimetro()
        {
            
            per = l * 4;
            Console.WriteLine("El perimetro es"+per+"\n");
            
            }
        public void Superficie()
        {
            sup = l + l;
            Console.WriteLine("La superficie es" +sup+"\n");
        }
  
        static void Main(string[] args)
        {
            Cuadrado cua = new Cuadrado();
            cua.CargarValores();
            cua.Perimetro();
            cua.Superficie();
            Console.ReadLine();


        }
    }
}
