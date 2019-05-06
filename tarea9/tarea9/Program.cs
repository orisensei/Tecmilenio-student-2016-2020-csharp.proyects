using System;

namespace tarea9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           //declaracion de las variables
            var x = new double[99];
            var y = new double[99];
            var matriz = new double[99, 7];
            double p, f;
            var x1 = 2.5;
            double y2 = 0;
            var dato1 = 0;

            // se piden los datos para la operacion
            Console.WriteLine("ingresa el tamaño de los pares de datos");
            dato1 = int.Parse(Console.ReadLine());


            for (var a = 0; a < dato1; a++)
            {
                Console.WriteLine("ingresa el tamaño de los pares de datos de x");
                x[a] = int.Parse(Console.ReadLine());
            }

            for (var b = 0; b < dato1; b++)
            {
                Console.WriteLine("ingresa el tamaño de los pares de datos de y");
                y[b] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("ingresa el valor del punto para obtener la interpolación");
            x1 = double.Parse(Console.ReadLine());


            for (var i = 0; i < dato1; i = i + 1)
            for (var j = 0; j < dato1; j = j + 1)
                matriz[i, j] = Math.Pow(x[i], j);
            for (var i = 0; i < dato1; i = i + 1) matriz[i, 6] = y[i];
            //Eliminación Gaussiana
            //------------------------------
            for (var re = 0; re < dato1; re = re + 1)
            {
                p = matriz[re, re];
                for (var col = 0; col < 7; col = col + 1) matriz[re, col] = matriz[re, col] / p;
                for (var reo = 0; reo < dato1; reo = reo + 1)
                    if (reo != re)
                    {
                        f = matriz[reo, re];
                        for (var colu = 0; colu < 7; colu = colu + 1)
                            matriz[reo, colu] = matriz[reo, colu]
                                                - f * matriz[re, colu];
                    }
            }

            //------------------------------     
           //impresion de los resultados
            for (var i = 0; i < dato1; i = i + 1) y2 = y2 + matriz[i, dato1] * Math.Pow(x1, i);

            Console.WriteLine("la interpolación esta dada en " + x1 + " es " + y2);
            Console.ReadLine();
        }
    }
}