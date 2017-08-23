using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Constructora
{
    class Constructora
    {
        
    
 //realice un algoritmo para que la empresa constructora tecno vivir que le permita calcular e imprimir la 
    //nomina para su cancelacion a un total de 50 obreros a 
    // quienes debe cancelar por horas trabajadas. la hora trabajada se pauto a 10 mil pesos
   

        float nom= 0, tiempo;

        public void iniciar()
        {
            Console.WriteLine("Tecno Vivir");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Digite las horas trabajo:");
                tiempo = float.Parse(Console.ReadLine());
            }
        }
        public void Resultado()
        {
            nom = nom +tiempo * 10000;
            Console.WriteLine("La nomina es"+ nom);
        }
        public static void Main(string[] args)
        {
            Constructora obre = new Constructora();
            obre.iniciar();
            obre.Resultado();
            Console.ReadLine();
        }
    }
}
