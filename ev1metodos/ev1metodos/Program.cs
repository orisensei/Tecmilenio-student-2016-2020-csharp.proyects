using System;

namespace ev1metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se inicializan las variables
            int s = 1, c = 1;   
            //Se crean 2 matrices 
            double[,] response = new double[10, 10];                  
            double[,] quiz = new double[10, 10];
            // Se crean un ciclo para validar que el susuario tecleo un numero abajo de 10 para la creacion de la matriz cuadrada
            do
            {//le pide al usuario ingresar el numero para generar la matriz
                Console.WriteLine("\nTecle el numero cuadrado de la matriz: debe ser menor a 10 elementos y presione [enter]:");
                s = int.Parse(Console.ReadLine());
                if ((s > 10) || (s < 1))
                {// si pone arriba de 10 le generara un mensaje de aviso
                    Console.WriteLine("\nDebe ser menor a 10 elementos por favor tecle de nuevo:");
                }
            } while ((s > 10) || (s < 1));
            //en base al numero generado se crearan los elementos
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    while (quiz[i, j] < 1000) 
                    {
                        //se teclean las variables tomando el limite que se pidio al principio
                        Console.WriteLine("\nTecle por favor la " + c + " variable:");
                        quiz[i, j] = double.Parse(Console.ReadLine());

                        if (quiz[i, j] < 1000)
                        {// si se teclea un numero abajo de 1000 generara un mensaje y le pedira nuevamente ingresar el numero
                            Console.WriteLine("\nDebe teclear un numero mayor a 1000 por favor tecle de nuevo:\n");
                        }
                    } 
                    c++;
                }
            }         
            // la matriz que generara los pasos para llegar a 1:
            Console.WriteLine("\nNumero de pasos usando la conjetura collatz para llegar a 1:\n");
           
            for (int d = 0; d < s; d++)
            {
                for (int n = 0; n < s; n++)
                {
                    while (quiz[d, n] > 1)
                    {
                        //si es par se dividira entre 2
                        if ((quiz[d, n] % 2) == 0)
                        {

                            quiz[d, n] = quiz[d, n] / 2;
                            response[d, n]++;
                        }// si es non se se multiplicara por 3 y se le sumara 1
                        else if ((quiz[d, n] % 2) == 1)
                        {

                            quiz[d, n] = 3 * quiz[d, n] + 1;
                            response[d, n]++;
                        }

                    }
                    // imprimira el resultado de la matriz
                    Console.Write(response[d, n] + ",");
                }
                Console.WriteLine();
            }
            // al teclear enter finalizara el .exe
            Console.WriteLine("\nTecle [enter] para salir\n");          
            Console.ReadLine();
        }
    }
}
