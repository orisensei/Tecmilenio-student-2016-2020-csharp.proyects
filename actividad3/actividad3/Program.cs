using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("\t\t\t\tActividad 3");
            Console.WriteLine("________________________________________________________________________________");

           double[,] posiciones = new double[999, 999];

            long[] vector = new long[100];
            

            int x = 0, y = 0;
            int contador = 1;
            double multiplicacion;
            int escoger;
            int calificaciones;
            double resultado = 0;
            long aux = 0;
            int ex =0;


            Console.WriteLine("ingrese [1] para hacer la matriz que multiplicara ");
            Console.WriteLine("ingrese [2] para capturar las calificaciones ");
            
            escoger = int.Parse(Console.ReadLine());

            switch (escoger)
            {
                case 1:
                   
                    Console.WriteLine("ingrese los renglones:");
                    x = int.Parse(Console.ReadLine());
                      
                    Console.WriteLine("ingrese las columnas:");
                    y = int.Parse(Console.ReadLine());
                   
                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Console.Write("ingrese el " + contador + " valor:\n");
                            posiciones[i, j] = double.Parse(Console.ReadLine());
                            contador++;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("________________________________________________________________________________");
                    Console.Write("ingrese un numero para multiplicar la matriz:\n");
                    multiplicacion = double.Parse(Console.ReadLine());
                    Console.WriteLine("________________________________________________________________________________");
                    Console.Write("matriz multiplicada\n");

                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Console.Write(posiciones[i, j] * multiplicacion + ",");
                        }
                        Console.WriteLine();
                    }
                    break;

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// segundo programa
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                case 2:
                    Console.WriteLine("ingrese la cantidad de materias a calificar:");
                    calificaciones = int.Parse(Console.ReadLine());
                  
                    for (int h = 0; h < calificaciones; h++)
                    {
                        Console.Write("ingrese la " + contador + " calificacion:\n");
                        vector[h] = long.Parse(Console.ReadLine());
                        contador++;
                        resultado = resultado + vector[h] / calificaciones;
                        
                    }

                   // Console.WriteLine("Calificaciones de la más baja hasta la más alta:");

                    for (int z = 1; z < calificaciones; z++)
                    {
                        for (int c = 0; c < calificaciones - z; c++) {

                            if (vector[c] > vector[c+1])
                            {
                                aux = vector[c];
                                vector[c] = vector[c + 1];
                                vector[c + 1] = aux;
                            }
                        }
                    
                    }

                    for (int w = 0; w < calificaciones; w++)
                    {
                      //  Console.Write(vector[w]+",");
                        ex = w;
                    }

                    Console.Write("\ncalificacion mas baja: " + vector[0]);
                    Console.Write("\ncalificacion mas alta: " + vector[ex]);
                    Console.Write("\ntu promedio del semestre es: " + resultado);
                    break;

            }
            Console.WriteLine("\n________________________________________________________________________________");
            Console.WriteLine("\t\t\tPresioine [enter] para salir ");
            Console.WriteLine("________________________________________________________________________________");
            Console.ReadLine();

        }
    }
}
