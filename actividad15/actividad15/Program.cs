using System;

namespace actividad15
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializar las variables.
            double y, k1, k2, k3, k4;
            double x = 0, p = 0.01;

            y = 7;

            // buscando el valor de la ecuación.
            while (x < 5)
            {

                k1 = -4 * y + Math.Sin(x);

                k2 = (-4 * (y + .5 * k1 * p) + Math.Sin(x) + 0.5 * p);
                k3 = (-4 * (y + .5 * k2 * p) + Math.Sin(x) + 0.5 * p);

                k4 = (-4 * (y + k3 * p) + Math.Sin(x) + 0.5 * p); ;

                y = y + (k1 + 2 * k2 + 2 * k3 + k4) * p / 6;

                x = x + p;

                Console.WriteLine(x);
            }
            // impresion de pantalla.
            Console.WriteLine("El valor de y cuando x es " + x + " es " + y);

            Console.ReadLine();
        }
    }
}
