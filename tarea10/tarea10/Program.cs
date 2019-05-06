using System;
namespace tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            // declaracion de variables
            double br, al1, al2, at, x;
            double p1 = 9500, a1 = 0;
            double ls = 0, li = 0;

            // pide los valores al usuario
            Console.WriteLine("Dame el limite superior");
            ls = double.Parse(Console.ReadLine());

            Console.WriteLine("Dame el limite inferior");
            li = Double.Parse(Console.ReadLine());


            // las operaciones
            br = (li - ls) / p1;

            x = ls;

            while (x < li)
            {
                al1 = Math.Exp(1/(x*x));
                x = x + br;
                al2 = Math.Exp(1/(x*x));
                at = (al1 + al2) / 2;

                a1 = a1 + br * at;
            }

            //imprime los valores

            Console.WriteLine("el limite superior es: "+ls);
            Console.WriteLine("el limite inferior es: " + li);
            Console.WriteLine("Trapecio: El valor del area es " + a1);


            Console.ReadLine();
        }
    }
}
