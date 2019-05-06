using System;

namespace Act8_tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion de las variables
            double x = 0.5, y = 2.2, x1, y1, z = 0.001;
            double p, f;
            double[,] matriz = new double[2, 3];
                    
            //Ecuacion  sin derivar X2 – y2 + 2y 
            x1 = x * x - y * y + 2 * y * y;
            //Ecuacion  sin derivar 2x – y2 – 6 = 0
            y1 = 2 * x - y * y  - 6;
            // Antes de entrar al ciclo

            //Ciclo while comparando el absoluto de x1 es mayor a Z o y1 es mayor a z
            while (Math.Abs(x1) > z || Math.Abs(y1) > z)
            {
                //Ecuacion  sin derivar X2 – y2 + 2y 
                x1 = x * x - y * y + 2 * y * y;
                //Ecuacion  sin derivar 2x – y2 – 6 = 0
                y1 = 2 * x - y * y - 6;

                /* la derivada de las 2 ecuciones 
                 * 2X – 2Y + 2
                 * 2 – 2Y   
                 * 
                --------------------------------------------------- */
                matriz[0, 0] = 2 * x;
                matriz[0, 1] = - 2 * y + 2;
                matriz[0, 2] = x1;
                matriz[1, 0] = 2;
                matriz[1, 1] = 2 - 2*y;
                matriz[1, 2] = y1;
                //-----------------------------------------------

                // Matriz Jacobi
                for (int i = 0; i < 2; i = i + 1)
                {
                    p = matriz[i, i];

                    for (int j = 0; j < 3; j = j + 1)
                    {
                        matriz[i, j] = matriz[i, j] / p;
                    }
                    for (int k = 0; k < 2; k = k + 1)
                    {
                        if (k != i)
                        {
                            f = matriz[k, i];

                            for (int m = 0; m < 3; m = m + 1)
                            {
                                matriz[k, m] = matriz[k, m] - f * matriz[i, m];
                            }
                        }
                    }
                }
          

                x = x + matriz[0, 2];
                y = y + matriz[1, 2];

            }
            // resultado de las operaciones
            Console.WriteLine("______________________________________________________________________________________________________");
            Console.WriteLine("Resultados de las operaciones: ");
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.ReadLine();
        }
    }
}
