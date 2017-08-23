using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile4
{
    class Program
    {
        static void Main(string[] args)
        {
           float num, saldo, suma, cant;
           saldo = 0;
           cant = 0;
               do{
                   Console.WriteLine("Digite numero de cuenta");
                   num=float.Parse(Console.ReadLine()); 
                   if (num > 0)
               {
                   Console.WriteLine("Digite el saldo");
                   saldo = float.Parse(Console.ReadLine());
                       if(saldo>0){
                           cant += saldo;
                       }
                       else
                       {
                           if (saldo < 0)
                           {
                               Console.WriteLine("Saldo deudor");
                           }
                           else
                               Console.WriteLine("Saldo nulo");
                           }

               }

               }while(num !=0);
               suma = cant;
               Console.WriteLine("El saldo de los acreedores es" + suma);
               Console.ReadKey();


        }
    }
}
