using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act10
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //inicializan las variables
            var jacobiana = new double[18, 3];
            var matriz = new double[3, 4];

            double[] mes = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18};
            double[] ventas = { 65, 69, 76, 82, 89, 94, 96, 96, 92, 85, 76, 67, 58, 60, 70, 80, 82, 89};


            for (var i = 0; i < 18; i++)
            {// ecuacion planteada
                jacobiana[i, 0] = mes[i];
                jacobiana[i, 1] = Math.Cos(mes[i]);
                jacobiana[i, 2] = mes[i] + 4 * ventas[i];

            }
            //matriz de multiplicacion
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
            for (var k = 0; k < 18; k++)
                matriz[i, j] = matriz[i, j] + jacobiana[k, i] * jacobiana[k, j];

            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 1; j++)
            for (var k = 0; k < 18; k++)
                matriz[i, 3] = matriz[i, 3] - ventas[k] * jacobiana[k, i];

            for (var r = 0; r < 3; r = r + 1)
            {
                var p = matriz[r, r];
                for (var c = 0; c < 4; c++)
                    matriz[r, c] = matriz[r, c] / p;
                for (var re = 0; re < 3; re++)
                    if (re != r)
                    {
                        var f = matriz[re, r];
                        for (var ce = 0; ce < 4; ce++)
                            matriz[re, ce] = matriz[re, ce] - f * matriz[r, ce];
                    }
            }
            //imprime el resultado
            Console.WriteLine("Resultado de la opcion 1\n");
            Console.WriteLine(matriz[0, 3] + ",\n" + matriz[1, 3] + ",\n" + matriz[2, 3] + ",\n");

            //---------------------------------------------------------------------------------------------------------------------

            //inicializan las variables
            var jacobi1 = new double[18, 3];
            var matrix = new double[3, 4];

            double[] t = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] ft = { 7.2074, 10.5465, 9.7056, 8.2160, 10.2054, 16.6029, 24.289468,28.9468, 29.0606, 27.2799};


            for (var i = 0; i < 10; i++)
            {// ecuacion planteada
                jacobi1[i, 0] = 1;
                jacobi1[i, 1] = t[i];
                jacobi1[i, 2] = Math.Cos(t[i])*(t[i]+ft[i]);

            }
            //matriz de multiplicacion
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
            for (var k = 0; k < 10; k++)
                matrix[i, j] = matrix[i, j] + jacobi1[k, i] * jacobi1[k, j];

            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 1; j++)
            for (var k = 0; k < 10; k++)
                matrix[i, 3] = matrix[i, 3] - ft[k] * jacobi1[k, i];

            for (var r = 0; r < 3; r = r + 1)
            {
                var p = matrix[r, r];
                for (var c = 0; c < 4; c++)
                    matrix[r, c] = matrix[r, c] / p;
                for (var re = 0; re < 3; re++)
                    if (re != r)
                    {
                        var f = matrix[re, r];
                        for (var ce = 0; ce < 4; ce++)
                            matrix[re, ce] = matrix[re, ce] - f * matrix[r, ce];
                    }
            }

            Console.WriteLine("Resultado de la opcion 2\n");
            Console.WriteLine(matrix[0, 3] + ",\n" + matrix[1, 3] + ",\n" + matrix[2, 3] + ",\n");

            Console.ReadLine();

        }

    }
}

