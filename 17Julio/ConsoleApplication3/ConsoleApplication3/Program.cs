using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que solicite la carga de un numero entre 0 y 999 y nos muestre un mensaje de cuantos digitos tiene el mismo finalicar el programa cuando se carge el valor 0//
            int valor;
            do
            {
            Console.WriteLine("Escriba un valor entre 0 y 999 (0 finaliza)");
                valor= int.Parse(Console.ReadLine());

                if(valor>=100){
                    Console.WriteLine("Tiene tres digitos");
                }else
                    if(valor>=10){
                    Console.WriteLine("Tiene dos digitos");
                    }else
                        Console.WriteLine("Tiene un digito");
                    


                }while (valor !=0);   
            
            }
    }
}
