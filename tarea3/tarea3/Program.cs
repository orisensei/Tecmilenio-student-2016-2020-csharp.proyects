using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 0, i, j =0, option=0, colegios, p;                     
            string[,] lugares1 = new string[999,999];
            string[,] nombre = new string[999,999];
           
            
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("Tarea 3");
            Console.WriteLine("_________________________________________________________________");

            Console.WriteLine("Teclea [1] para la opcion 1 y [enter]");
            Console.WriteLine("Teclea [2] para la opcion 2 y [enter]");
            option = int.Parse(Console.ReadLine());

            switch (option) {
                case 1:
                    Console.WriteLine(" En cuantos estados de la republica has visitado en tu vida? y teclea [enter] ");
                    n = int.Parse(Console.ReadLine());

                    for (i = 1; i <= n; i++)
                    {
                        Console.WriteLine(" Cuáles fueron los lugares donde estuvo en cada uno de los estados? y teclea [enter]");
                        lugares1[0,i] = Console.ReadLine();
                      
                    }

                    for (j = 0; j <= 0; j++)
                    {
                        Console.WriteLine(" cuenta una anécdota que te recuerde todos esos lugares y teclea [enter]");
                        lugares1[1, 0] = Console.ReadLine();
                    }

                    Console.WriteLine("Resultados");
                    Console.WriteLine("_________________________________________________________________");

                    Console.WriteLine("Numeros de estados que visitaste:" + n);
                    Console.WriteLine("Lugares visitados:");

                    for (i = 1; i <= n; i++)
                    {
                        Console.Write(lugares1[0, i] +",");
                        
                    }
                    for (j = 0; j <= 0; j++)
                    {
                        Console.WriteLine("\n"+ lugares1[1, 0]+",");
                         
                    }

                    break;
                case 2:
                 
                    Console.WriteLine("\nTeclea la cantidad de colegios a las que has asistido y teclea [enter]");
                    colegios = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nTeclea la cantidad de profesores de los colegios que asististe y teclea [enter]");
                    p = int.Parse(Console.ReadLine());

                        for (i = 0; i < p; i++)
                        {
                            Console.WriteLine("Teclea los nombres de los profesores y teclea [enter]");
                            nombre[0,i] = Console.ReadLine();

                        }
                            Console.WriteLine("Numero de colegios son: " + colegios);
                            Console.WriteLine("Numero de profesores son: " + p);
                            Console.WriteLine("Los nombres de los profesores son: ");
                            for (j = 0; j < p; j++)
                            {
                                 Console.Write(nombre[0,j]+",");                               
                            }
                    break;
                default:
                    Console.WriteLine("Teclea [enter] para finalizar");
                    break;
            }        
            Console.ReadLine();
        }
    }
}
