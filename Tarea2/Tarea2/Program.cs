using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            double flotante, raiz = 0;
            bool num;
           
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("Tarea 2");
            Console.WriteLine("________________________________________________________________");


            Console.WriteLine("Ingresa un numero entero o de fraccion:");
            flotante = double.Parse(System.Console.ReadLine());

            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("Resultados");
            Console.WriteLine("________________________________________________________________");

            num = flotante % 1 == 0 ? true : false;

            if (num == true)
            {
                Console.WriteLine("El numero ingresado es entero\n");
            }
            else
            {
               Console.WriteLine("El numero ingresado es fraccion\n");
            }
      
                 if (flotante % 2 == 0)
                 {
                    Console.WriteLine("El numero es par \n");
                 }
                 else if (flotante % 2 == 1)
                 {
                   Console.WriteLine("El numero es impar \n");
                 }
                 else
                 {
                   Console.WriteLine("El numero no es par ni impar \n");
                 }
      
       for (int i = 0; i < flotante; i++)
       {

         raiz = Math.Sqrt(flotante);

       }

       Console.WriteLine("la raiz cuadrada es:" + raiz);

            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("Tecle [enter] para salir");
            Console.WriteLine("________________________________________________________________");
            Console.ReadLine();
        }
    }
}
