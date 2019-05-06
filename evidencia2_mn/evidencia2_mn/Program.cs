using System;

/*
  1.  Método de mínimos cuadrados que se ajusten a la curva para cada niño.
  2.  Sistema de ecuaciones no lineales para identificar donde se intersectan
  3.  Raices de ecuaciones no lineales
 */
namespace evidencia2_mn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double p, f;
            var ja = new double[12, 4];
            var mat = new double[3, 4];

            //Temperaturas de cada mes
            double[] meses = {50, 55, 60, 61, 65, 67, 69, 70, 72, 73, 74, 76};
            double[] time = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

            for (var i = 0; i < 12; i = i + 1)
            {
                ja[i, 0] = 1;
                ja[i, 1] = Math.Sin(time[i]);
                ja[i, 2] = Math.Cos(time[i]);
            }

            //Multiplicación de matrices
            //------------------------------
            for (var i = 0; i < 3; i = i + 1)
            for (var j = 0; j < 3; j = j + 1)
            for (var k = 0; k < 12; k = k + 1)
                mat[i, j] = mat[i, j] + ja[k, i] * ja[k, j];

            for (var i = 0; i < 3; i = i + 1)
            for (var j = 0; j < 1; j = j + 1)
            for (var k = 0; k < 12; k = k + 1)
                mat[i, 3] = mat[i, 3] - meses[k] * ja[k, i];
            //------------------------------

            //Eliminación Gaussiana
            //------------------------------
            for (var r = 0; r < 3; r = r + 1)
            {
                p = mat[r, r];
                for (var c = 0; c < 4; c = c + 1)
                    mat[r, c] = mat[r, c] / p;
                for (var re = 0; re < 3; re = re + 1)
                    if (re != r)
                    {
                        f = mat[re, r];
                        for (var coli = 0;
                            coli < 4;
                            coli = coli + 1)
                            mat[re, coli] = mat[re,
                                                coli] - f * mat[r, coli];
                    }
            }
            //------------------------------

            //Imprime los valores de las variables
            Console.WriteLine("anibal " + " x1: " + mat[0, 3] + " x2: " + mat[1, 3] + " x3: " + mat[2, 3] + " ");
            //_______________________________________________________________________________

            //Temperaturas de cada mes
            double[] mese2 = {49, 57, 59, 61, 63, 65, 67, 69, 70, 71, 72, 74};
            double[] time1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

            for (var i = 0; i < 12; i = i + 1)
            {
                ja[i, 0] = 1;
                ja[i, 1] = Math.Sin(time1[i]);
                ja[i, 2] = Math.Cos(time1[i]);
            }

            //Multiplicación de matrices
            //------------------------------
            for (var i = 0; i < 3; i = i + 1)
            for (var j = 0; j < 3; j = j + 1)
            for (var k = 0; k < 12; k = k + 1)
                mat[i, j] = mat[i, j] + ja[k, i] * ja[k, j];

            for (var i = 0; i < 3; i = i + 1)
            for (var j = 0; j < 1; j = j + 1)
            for (var k = 0; k < 12; k = k + 1)
                mat[i, 3] = mat[i, 3] - mese2[k] * ja[k, i];
            //------------------------------

            //Eliminación Gaussiana
            //------------------------------
            for (var r = 0; r < 3; r = r + 1)
            {
                p = mat[r, r];
                for (var c = 0; c < 4; c = c + 1)
                    mat[r, c] = mat[r, c] / p;
                for (var re = 0; re < 3; re = re + 1)
                    if (re != r)
                    {
                        f = mat[re, r];
                        for (var coli = 0;
                            coli < 4;
                            coli = coli + 1)
                            mat[re, coli] = mat[re,
                                                coli] - f * mat[r, coli];
                    }
            }
            //------------------------------

            //Imprime los valores de las variables
            Console.WriteLine("maria " + " x1: " + mat[0, 3] + " x2: " + mat[1, 3] + " x3: " + mat[2, 3] + " ");

            Console.ReadLine();
        }
    }
}