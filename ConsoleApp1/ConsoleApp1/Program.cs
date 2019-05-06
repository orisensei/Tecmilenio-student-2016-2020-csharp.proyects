using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("                                 Tarea 1                                     ");
            Console.WriteLine("________________________________________________________________________________");

            double dato_1, dato_2;
            double resultado_1, resultado_2, resultado_3, residuo;
            bool compara_1, compara_2, compara_3;

            Console.WriteLine("ingresa la variable 1");
            dato_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingresa la variable 2");
            dato_2 = double.Parse(Console.ReadLine());


            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("                                 Operaciones matematicas                        ");
            Console.WriteLine("________________________________________________________________________________");

            resultado_1 = dato_1 + dato_2;
            Console.WriteLine("Resultado_1: "+ resultado_1);

            resultado_2 = dato_1 * dato_2;
            Console.WriteLine("Resultado_2: " + resultado_2);

            resultado_3 = resultado_1 % resultado_2;
            Console.WriteLine("Resultado_3: " + resultado_3);

            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("                                 Operaciones booleanas                          ");
            Console.WriteLine("________________________________________________________________________________");

            compara_1 = dato_1 == dato_2;
            Console.WriteLine("compara_1: " + compara_1);

            compara_2 = dato_1 > dato_2;
            Console.WriteLine("compara_1: " + compara_2);

            compara_3 = compara_1 & compara_2;
            Console.WriteLine("compara_1: " + compara_3);

            Console.ReadLine();
        }
    }
}
