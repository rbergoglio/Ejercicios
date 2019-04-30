using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Entrevistas
    {
        public static int NumMasPopular(int[] arreglo, int longitud)
        {
            int max = 0;
            int index = 0;
            var arregloNumeros = new int[4999];
            //usar un vector de longitud 5000 no esta bien, pero es la primera solucion al problema que se me ocurrio
            foreach (var numero in arreglo)
            {
                arregloNumeros[numero - 1]++;
            }

            for (var i = 0; i < 5000 - 1; i++)
            {
                if (max < arregloNumeros[i])
                {
                    max = arregloNumeros[i];
                    index = i;
                }
            }

            return index + 1;
        }

        public static bool IsCasiPalindromo(string palabra)
        {
            //esta 'mal' echo, deberia fijarme solo la mitad y error ser 1
            int errores = 0;
            StringBuilder dadaVuelta = new StringBuilder(palabra);
            for (var i = 0; i <= palabra.Length - 1; i++)
            {
                dadaVuelta[palabra.Length - i - 1] = palabra[i];
            }

            for (var i = 0; i < palabra.Length - 1; i++)
            {
                if (palabra[i] != dadaVuelta[i])
                    errores++;
            }

            return errores > 2;
        }

        public static double distancia(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double distanciaTresPuntos(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            return (distancia(x1, y1, x2, y2) + distancia(x1, y1, x3, y3) + distancia(x2, y2, x3, y3)) / 3;
        }
    }
}
