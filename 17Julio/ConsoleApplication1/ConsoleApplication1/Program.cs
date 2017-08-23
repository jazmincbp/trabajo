using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
      
              static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            int a, x,j, res;

            Console.WriteLine("Digite un numero");
            j = int.Parse(Console.ReadLine());

            for (x = 1; x <= 10; x++)
            {
                for(a=1; a<=10; a++){
            
                res = x*a;
               // res= int.Parse(Console.ReadLine());
               Console.WriteLine("La multiplicacion es" + x + "*" + a + "=" +res);
                } 
            }
            Console.ReadKey();
              }
    }
}
