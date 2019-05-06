using System;

namespace tarea11
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            double bass1, alt1, alt2, alt3, altotal, x;
            double p = 0, a = 0;
            double lim_i = 0, lim_s = 0;


            // se le piden los datos al usuario
            Console.WriteLine("Teclea el limite inferior");
            lim_i = Double.Parse(Console.ReadLine());

            Console.WriteLine("Teclea el limite superior");
            lim_s = Double.Parse(Console.ReadLine());

            Console.WriteLine("Cuantas partes desea partir la integral");
            p = Double.Parse(Console.ReadLine());


            bass1 = (lim_s - lim_i) / p;

            x = lim_i;

            // regla de simpson

            while (x < lim_s)
            {
                alt1 = -x * x * x + 10 * x * x + 8 * x + 10;
                x = x + bass1 / 2;
                alt2 = -x * x * x + 10 * x * x + 8 * x + 10;
                x = x + bass1 / 2;
                alt3 = -x * x * x + 10 * x * x + 8 * x + 10;

                altotal = (alt1 + 4 * alt2 + alt3) / 6;
                a = a + (bass1) * altotal;
            }
            // resultados
            Console.WriteLine("Resultado " + a);
            Console.ReadLine();




        }
    }
}
