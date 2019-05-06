using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0, hora, hora2, resultado1 = 0, i = 0, j = 0, numero = 0, residuo1 = 0, roller = 0;
           
            Console.WriteLine("Teclea 1 para la actividad 2  opcion1");
            Console.WriteLine("Teclea 2 para la actividad 2  opcion2");
            menu = int.Parse(Console.ReadLine());

            switch (menu) {

                case 1:
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("Programa 1, opcion 1");
            Console.WriteLine("_______________________________________________________________________________");


            do
            {
                Console.WriteLine("A que hora te vas a dormir ingrese un numero entero entre (0 a 23 horas)? ");
                hora = int.Parse(Console.ReadLine());
                if ((hora <= -1) || (hora >= 24))
                {
                    Console.WriteLine("Esa no es una hora valida por favor vuelva a introduccir la hora \n");
                }

            } while ((hora <= -1) != (hora >= 24));


            switch (hora)
            {
                case 0:
                case 1:

                    hora2 = hora + 8;
                    Console.WriteLine("duerme usted un poco tarde, trate de descanzar mas, hora recomendada: " + hora2 + " horas"); break;

                case 2:
                case 3:
                case 4:
                    hora2 = hora + 8;
                    Console.WriteLine("Usted duerme muy tarde, eso no es bueno para la salud, Hora recomendada: " + hora2 + " horas"); break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    hora2 = hora + 8;
                    Console.WriteLine("Supongo que duerme a estas horas porque tiene un trabajo nocturno, hora recomendada " + hora2 + " horas"); break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    hora2 = hora + 8;
                    Console.WriteLine("Usted tiene un horario de sueño muy extraño, hora recomendada " + hora2 + " horas"); break;
                case 19:
                case 20:
                    hora2 = hora + 8;
                    Console.WriteLine("Usted duerme muy temprano " + hora2 + " horas"); break;
                case 21:
                case 22:
                    hora2 = hora + 8;
                    Console.WriteLine("Usted duerme a muy buena hora, felicidades, hora recomendada " + hora2 + " horas"); break;
                case 23:
                    hora2 = 8;
                    Console.WriteLine("duerme usted un poco tarde, trate de descanzar mas " + hora2 + " horas"); break;
                default: Console.WriteLine("Esa no es una hora valida"); break;

            }

                
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("Programa 2");
            Console.WriteLine("_______________________________________________________________________________");

            for (i = 0; i < 10; i++)
            {


                for (j = 0; j < 10; j++)
                {


                    resultado1 = resultado1 + i;


                }


            }
            Console.WriteLine("la multiplicacion de todos los numeros de 1 al 10 que da como suma es: " + resultado1);
                   


                
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("Programa 3");
            Console.WriteLine("_______________________________________________________________________________");

            Console.WriteLine("ingresa un numero entero ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado de los numeros ");
            residuo1 = numero;

            while (residuo1 % 2 == 0)
            {

                residuo1 /= 2;

                roller++;
                Console.Write(residuo1 + ",");



            }
                    break;

                case 2:
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("Programa 1, opcion 2");
                    Console.WriteLine("_______________________________________________________________________________");


                    do
                    {
                        Console.WriteLine("A que hora te vas a dormir ingrese un numero entero entre (0 a 23 horas)? ");
                        hora = int.Parse(Console.ReadLine());
                        if ((hora <= -1) || (hora >= 24))
                        {
                            Console.WriteLine("Esa no es una hora valida por favor vuelva a introduccir la hora \n");
                        }

                    } while ((hora <= -1) != (hora >= 24));


                    switch (hora)
                    {
                        case 0:
                        case 1:

                            hora2 = hora + 8;
                            Console.WriteLine("duerme usted un poco tarde, trate de descanzar mas"); break;

                        case 2:
                        case 3:
                        case 4:
                            hora2 = hora + 8;
                            Console.WriteLine("Usted duerme muy tarde, eso no es bueno para la salud"); break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            hora2 = hora + 8;
                            Console.WriteLine("Supongo que duerme a estas horas porque tiene un trabajo nocturno"); break;
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            hora2 = hora + 8;
                            Console.WriteLine("Usted tiene un horario de sueño muy extraño"); break;
                        case 19:
                        case 20:
                            hora2 = hora + 8;
                            Console.WriteLine("Usted duerme muy temprano "); break;
                        case 21:
                        case 22:
                            hora2 = hora + 8;
                            Console.WriteLine("Usted duerme a muy buena hora, felicidades"); break;
                        case 23:
                            hora2 = 8;
                            Console.WriteLine("duerme usted un poco tarde, trate de descanzar mas"); break;
                       
                    }
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("Programa 2");
                            Console.WriteLine("_______________________________________________________________________________");

                            for (i = 0; i < 1000; i++)
                            {                       
                                resultado1 = resultado1 + i;                    
                            }

                            Console.WriteLine("la suma de 1 a 1000 es " + resultado1);


                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("Programa 3");
                            Console.WriteLine("_______________________________________________________________________________");

                            Console.WriteLine("ingresa un numero entero ");
                            numero = int.Parse(Console.ReadLine());

                            Console.WriteLine("Resultado de los numeros ");
                            residuo1 = numero;

                            while (residuo1 % 2 == 0)
                            {

                                residuo1 /= 2;

                                roller++;
                        
                            }
                               if (roller == 0)
                                {
                                    Console.WriteLine("el numero " + residuo1 + " no es divisible entre 2");

                                }
                               else
                                {
                                    Console.WriteLine("El número " + numero + " puede dividirse " + roller + " veces entre 2");
                                }

                    break;
        }

           



            Console.ReadLine();

        }
    }
}
