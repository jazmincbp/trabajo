using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        
            private string[] paises;

            public void Cargar()
            {

                paises = new string[5];
                for (int i = 0; i < paises.Length; i++)
                {
                    Console.WriteLine("Digite pais");
                    paises[i] = Console.ReadLine();
                }
            }
            public void Ordenar(){
                for (int k = 0; k < 4; k++)
			{
                    for (int i = 0; i < 4 - k; i++)
			{
			    if (paises[i].CompareTo(paises[i+1])>0){
                    string aux;
                    aux = paises[i];
                    paises[i] = paises[i+1];
                    paises[i+1] = aux;
                }
			}
			 
			}
            }
        public void Imprimir(){
            Console.WriteLine("Paises ordenados en forma Alfabetica:");
                for (int i = 0; i < paises.Length; i++)

			{
			 Console.WriteLine(paises[i]);
			}
            }


       static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Ordenar();
           p.Imprimir();
            Console.ReadLine();
        }
    }
}
