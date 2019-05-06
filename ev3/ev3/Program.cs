using System;

namespace ev3
{
    class Program
    {
        static void Main(string[] args)
        {
            //nombrar las variables
            double vi = 15, vf = 0, d = 0, t = 0, g = 9.81;
            double d1 = 100, d2 = 150, d3 = 250, d4 = 300;      
            int dato = 0;
            double op = 0;

            double tiempo1 = 15,tiempo2 = 20, distancia1 = 120, distancia2 = 210, v1 = 0,v2 = 0;
            //impresion de datos
            v1 = distancia1 * tiempo1;
            Console.WriteLine("Camino recorrido en 120 es: "+ v1);


            v2 = distancia2 * tiempo2;
            Console.WriteLine("Camino recorrido en 120 es: " + v2);


            // switch de datos y sus resultados
            Console.WriteLine("para distacia de 100 presiona [1]");
            Console.WriteLine("para distacia de 150 presiona [2]");
            Console.WriteLine("para distacia de 250 presiona [3]");
            Console.WriteLine("para distacia de 300 presiona [4]");
            dato = Int32.Parse(Console.ReadLine());

            switch (dato)
            {
                case 1:

                    d = 100;

                    t = d / vi;

                    d = t * vi;

                    vf = vi + g * t;


                    Console.WriteLine("la distancia es: "+ d);
                    Console.WriteLine("la velocidad final es: " + vf);

                    break;
                case 2:
                    d = 150;

                    t = d / vi;

                    d = t * vi;

                    vf = vi + g * t;


                    Console.WriteLine("la distancia es: " + d);
                    Console.WriteLine("la velocidad final es: " + vf);
                    break;
                case 3:
                    d = 250;

                    t = d / vi;

                    d = t * vi;

                    vf = vi + g * t;


                    Console.WriteLine("la distancia es: " + d);
                    Console.WriteLine("la velocidad final es: " + vf);
                    break;
                case 4:
                    d = 300;

                    t = d / vi;

                    d = t * vi;

                    vf = vi + g * t;


                    Console.WriteLine("la distancia es: " + d);
                    Console.WriteLine("la velocidad final es: " + vf);
                    break;
                default:
                    Console.WriteLine("numero invalido");
                    break;
                    //fin
            }
        }
    }
}




/*
 * Resuelve esta ecuación considerando un terreno plano, una gravedad constante de
 * 9.81 m/s2 y el viento sin movimiento. Los casos para los que los debes resolver
 * son para distancias de 100, 150, 250 y 300 metros, con una velocidad inicial de 15 m/s.
 * El programa debe de arrojar cuál es la distancia, así como su velocidad final.
*/
