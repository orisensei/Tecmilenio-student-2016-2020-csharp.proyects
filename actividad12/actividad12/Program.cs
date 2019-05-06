using System;

namespace actividad12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double bass, bass2, x;
            double por = 1000, arr = 0;
            double limit1 = -10, limit2 = 10;

            bass = (limit2 - limit1) / por;

            x = limit1;

            while (x < limit2)
            {
                bass2 = Math.Sin(x) / x + 1;
                arr = arr + bass * bass2;
                x = x + bass;
            }

            Console.WriteLine("Rectangulo: El valor del area es " + arr);

            //............................................................................

            double br, al1, al2, at, x1;
            double p1 = 1000, a1 = 0;
            double ls = -10, li = 10;

            br = (li - ls) / p1;

            x1 = ls;

            while (x1 < li)
            {
                al1 = Math.Sin(x) / x + 1;
                x1 = x1 + br;
                al2 = Math.Sin(x) / x + 1;
                at = (al1 + al2) / 2;

                a1 = a1 + br * at;
            }

            Console.WriteLine("Trapecio: El valor del area es " + a1);


            Console.ReadLine();
        }
    }
}