using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_6
{
    // f(x) = x³ - 10x -5 Biseccion 
    // y = x² - 2x - 1  Secante


    class Program
    {
        static void Main(string[] args)
        {


            String ec = "";
           
            Console.WriteLine("Metodo bisección tecle [1]");
            Console.WriteLine("Metodo secante tecle [2]");
            Console.WriteLine("tecle cualquiera para salir");
            ec = Console.ReadLine();

            int numero = int.Parse(ec);

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Metodo bisección");
                    Console.WriteLine("___________________________________________");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Metodo secante");
                    Console.WriteLine("___________________________________________");
                    // se declaran las variables
                    double x = -5, x1 = 0, y, y1, a = 0, y2, op = 1, ed = 0.0000001;

                    //ecuacion de y = 5x^2 -2x -1 antes de entrar al ciclo

                    y = 5 * x * x - 2 * x - 1;
                    y1 = y;

                    while (y * y1 > 0)
                    {
                        x1 = x;
                        x = x1 + op;

                        y1 = y;

                        //ecuacion de y = 5x^2 -2x -1
                        y = 5 * x * x - 2 * x - 1;
                    }

                    if (y == 0)
                    {
                        Console.WriteLine("Se encontró la raiz cuadrada en: " + x);
                    }

                    while ((Math.Abs(y) > ed) & (Math.Abs(y1)
                        > ed))
                    {
                        a = x1 + (y * (x1 - x)
                            / (y1 - y));
                        y2 = 5 * a * a - 2 * a - 1;

                        if (y2 * y > 0)
                        {
                            x = a;
                            y = y2;
                        }
                        else
                        {
                            x1 = a;
                            y1 = y2;
                        }
                    }

                    Console.WriteLine("El intervalo de la raíz está entre: "
                        + x1 + " y " + x);
                    Console.WriteLine("La media es: " + a);

                    Console.ReadLine();
                    break;

               
                default:
                    Console.WriteLine("Salir del programa");
                    Console.WriteLine("___________________________________________");
                    Console.ReadLine();
                    break;
                
            }
        }
    }
}
