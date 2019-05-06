using System;

namespace actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] gauss = {{2, 7, 3, -7},
                               {1, 3, 4,  3},
                               {1, 4, 3, -2}};

            double p, f;

            Console.WriteLine("________________________________________________");
            Console.WriteLine("actividad 6");
            Console.WriteLine("________________________________________________\n");

            Console.WriteLine("\nMatriz inicial\n");

            // matriz inicial antes de proceder a la operación donde imprimira lo que se va resolver
            for (int a = 0; a < 3; a++)
            {


                for (int b = 0; b < 4; b++)
                {
                    Console.Write(gauss[a, b] + ",");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________");
            Console.WriteLine("\nresultado de la operación tecle [enter]");
           
            Console.ReadLine();

            Console.WriteLine("Resultado\n");
            // matriz donde se hace la operación usando el metodo de gauss
            for (int i = 0; i < 3; i++)
            {
             
                p = gauss[i, i];

               
                for (int j = 0; j < 4; j++)
                {
               
                    gauss[i, j] = gauss[i, j] / p;
                }
         
                for (int k = 0; k < 3; k++)
                {
                    if (k != i)
                    {
                       
                        f = gauss[k, i];
                     
                        for (int m = 0; m < 4; m++)
                        {
                            gauss[k, m] = gauss[k, m] - f * gauss[i, m];
                        }
                    }
                }
            }

       
            // Aqui se imprime la matriz resultante despues de hacer la eliminación por gauss jordan
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(gauss[x, y]+ ",");
                }

                Console.WriteLine();
            }


            Console.WriteLine("________________________________________________");
            Console.WriteLine("\ntecle [enter] para salir");

            Console.ReadLine();
        }
    }
}
