using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE8
{
    class MayorMenor
    {
       
            

            private int v1,v2,v3;
            private int May,Men;

        public void CargarValores()
        { 
            Console.WriteLine("Digite valor 1");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 2");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 3");
            v3 = int.Parse(Console.ReadLine());
            May = CalcularMayor( v1, v2, v3);
            Men = CalcularMenor(v1, v2, v3);
            Console.WriteLine("El valor mayor es" + May);
            Console.WriteLine("El valor menor es" + Men);

        }
        public int CalcularMayor(int v1,int v2,int v3){
            int m;
            if(v1>v2 && v1>v3){
                m=v1;
            }
            else{
                if
                    (v2>v3)
                { 
                    m=v2;
            }
                else
                {
                    m=v3;
                }
        }
           return m;
        } 

        public int CalcularMenor(int v1, int v2, int v3){
            int m;
            if(v1<v2 && v1<v2){
                m = v1;
            }
            else
            {
                if
                    (v2 < v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }
        static void Main(string[] args)
        {
            MayorMenor mm = new MayorMenor();
            mm.CargarValores();
            Console.ReadLine();


        }
        
    }
}
