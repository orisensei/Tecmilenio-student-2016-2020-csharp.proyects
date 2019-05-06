using System;

namespace Tarea12_act14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //delcaración de variables
            double y, yy, yyy;
            double x = 0, paso = 0.01;

            y =  1;
            yy = 2;

            //ciclo de ecuacion

            while (x < 2)
            {
                yyy = -Math.Sin(x) + 5 * y * Math.Cos(x);

                y = y + yy * paso + yyy * paso * paso;

                yy = yy + yyy * paso;

                x = x + paso;

                //impresion en pantalla
                Console.WriteLine(x);
            }

            Console.WriteLine("El valor de y cuando x es " + x + " es " + y);

            Console.ReadLine();
        }
    }
}