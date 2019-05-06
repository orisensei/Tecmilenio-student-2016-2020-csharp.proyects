using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] programa = new int[900, 900];

            double fibo1 = 0, fibo2 = 0, x = 0;

            
                Console.WriteLine("Teclea el primer termino");
                fibo1 = int.Parse(Console.ReadLine());
           
           
            do
            {
                fibo1 = x;
              
                Console.WriteLine("Teclea el segundo termino");
                fibo1 = int.Parse(Console.ReadLine());
                if (fibo1 > fibo2)
                {
                    Console.WriteLine("Error el numero debe ser mayor");
                }
            } while(fibo1 > fibo2);

           
          /*  do
            {
                x = fibo1;
                fibo1 = fibo2;
                fibo2 = x + fibo1;

            } while (fibo2 + fibo1 <= 1000);

            Console.WriteLine("Resultado de fibonacchi:"+ fibo2);*/
            
            Console.ReadLine();
        }
    }
}
