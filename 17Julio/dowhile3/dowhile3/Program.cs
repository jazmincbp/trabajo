using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile3
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Realizar un programa que permita ingresar el peso en kilogramos de piezas.El proceso termina cuando ingresamos el valor 0, se debe informar:
            //a cuantas piezas tienen peso entre 9.8kg y 10.2kg, cuantas con mas de 10.2kg y cuantas con menos de 9.8kg
            //b generar la cantidad total de piezas procesadas

            float uno, dos,tres, peso, suma;
            uno = 0;
            dos = 0;
            tres = 0;
            do
            {
                Console.WriteLine("Digite el peso de la pieza");
                peso = float.Parse(Console.ReadLine());
              
            if (peso>10.2){
                uno++;
            }else
                 if (peso>9.8){
                     dos++;
                 }else
                     if(peso >0){
                         tres++;        
                     }
            
  
        }while(peso  != 0);
            suma = uno + dos + tres;

            Console.WriteLine("Piezas aptas" + dos);

            Console.WriteLine("Piezas superiores" + uno);

            Console.WriteLine("Piezas inferiores" + tres);

            Console.WriteLine("Total de las piezas es" + suma);

            Console.ReadLine();
    
        }
    }
}
