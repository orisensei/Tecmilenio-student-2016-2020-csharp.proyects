using System;

namespace actividad13
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaracion de valores
            int selec = 0;
            double bass1, alt1, alt2, alt3, altotal, x1;
            double p = 0, a = 0;
            double lim_i = -10, lim_s = 10;


            // se le pide al usuario la cantidad de partes con un switch
            Console.WriteLine("teclea [1] para 2 elementos");
            Console.WriteLine("teclea [2] para 5 elementos");
            Console.WriteLine("teclea [3] para 10 elementos");
            Console.WriteLine("teclea [4] para 20 elementos");
            Console.WriteLine("teclea [5] para 100 elementos");
            Console.WriteLine("teclea [6] para 5000 elementos");
            Console.WriteLine("teclea [7] para 10000 elementos");
            selec = Int32.Parse(Console.ReadLine());


            // dependiendo el switch este escoge
            switch (selec)
            {
                case 1:
                    p = 2;

                    bass1 = (lim_s - lim_i) / p;

                    x1 = lim_i;

                    while (x1 < lim_s)
                    {
                        alt1 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt2 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt3 = (Math.Sin(x1) / x1) + 1;

                        altotal = (alt1 + 4 * alt2 + alt3) / 6;
                        a = a + (bass1) * altotal;
                    }

                    Console.WriteLine("El valor de 2 partes es: " + a);
                    Console.ReadLine();

                    break;

                case 2:

                    p = 5;

                    bass1 = (lim_s - lim_i) / p;

                    x1 = lim_i;

                    while (x1 < lim_s)
                    {
                        alt1 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt2 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt3 = (Math.Sin(x1) / x1) + 1;

                        altotal = (alt1 + 4 * alt2 + alt3) / 6;
                        a = a + (bass1) * altotal;
                    }

                    Console.WriteLine("El valor de 5 partes es: " + a);
                    Console.ReadLine();

                    break;

                case 3:

                    p = 10;

                    bass1 = (lim_s - lim_i) / p;

                    x1 = lim_i;

                    while (x1 < lim_s)
                    {
                        alt1 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt2 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt3 = (Math.Sin(x1) / x1) + 1;

                        altotal = (alt1 + 4 * alt2 + alt3) / 6;
                        a = a + (bass1) * altotal;
                    }

                    Console.WriteLine("El valor de 10 partes es: " + a);
                    Console.ReadLine();

                    break;

                case 4:

                    p = 20;

                    bass1 = (lim_s - lim_i) / p;

                    x1 = lim_i;

                    while (x1 < lim_s)
                    {
                        alt1 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt2 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt3 = (Math.Sin(x1) / x1) + 1;

                        altotal = (alt1 + 4 * alt2 + alt3) / 6;
                        a = a + (bass1) * altotal;
                    }

                    Console.WriteLine("El valor de 20 partes es: " + a);
                    Console.ReadLine();

                    break;

                case 5:

                    p = 100;

                    bass1 = (lim_s - lim_i) / p;

                    x1 = lim_i;

                    while (x1 < lim_s)
                    {
                        alt1 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt2 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt3 = (Math.Sin(x1) / x1) + 1;

                        altotal = (alt1 + 4 * alt2 + alt3) / 6;
                        a = a + (bass1) * altotal;
                    }

                    Console.WriteLine("El valor de 100 partes es: " + a);
                    Console.ReadLine();

                    break;

                case 6:

                    p = 5000;

                    bass1 = (lim_s - lim_i) / p;

                    x1 = lim_i;

                    while (x1 < lim_s)
                    {
                        alt1 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt2 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt3 = (Math.Sin(x1) / x1) + 1;

                        altotal = (alt1 + 4 * alt2 + alt3) / 6;
                        a = a + (bass1) * altotal;
                    }

                    Console.WriteLine("El valor de 5000 partes es: " + a);
                    Console.ReadLine();

                    break;
                case 7:

                    p = 10000;

                    bass1 = (lim_s - lim_i) / p;

                    x1 = lim_i;

                    while (x1 < lim_s)
                    {
                        alt1 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt2 = (Math.Sin(x1) / x1) + 1;
                        x1 = x1 + bass1 / 2;
                        alt3 = (Math.Sin(x1) / x1) + 1;

                        altotal = (alt1 + 4 * alt2 + alt3) / 6;
                        a = a + (bass1) * altotal;
                    }

                    Console.WriteLine("El valor de 10000 partes es: " + a);
                    Console.ReadLine();

                    break;
            }

            // fin del programa
          
        }
    }
}
