using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Entrevistas
    {
        //ejercicios tipicos de entrevistas resueltos
        public static int MostPopularNum(int[] array, int longitude)
        {
            /*
            Hacer una funcion que reciba un array de numeros y la longitud de ese array. Los numeros pueden ser de 1 a 5000.
            Devolver el numero que mas se repita y si hay uno o mas con la misma cantidad de veces que se repiten devolver el menor.*/

            int max=array[0], index = 0;
            var arrayNumbers = new int[4999];
            //TODO: usar un vector de longitud 5000 no es muy lindo. Podria hacer otra solucion con un conjunto y una lista de tuplas

            foreach (var number in array)
                arrayNumbers[number - 1]++;

            for (var i = 0; i < 5000 - 1; i++)
            {
                if (max < arrayNumbers[i])
                {
                    max = arrayNumbers[i];
                    index = i;
                }
            }

            return index + 1;
        }

        public static bool IsAlmostPalindromic(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentException("Value cannot be null or empty.", nameof(word));

            int errors = 0;
            var reverseWord = new StringBuilder(word);

            for (var i = 0; i <= word.Length - 1; i++)
                reverseWord[word.Length - i - 1] = word[i];

            for (var i = 0; i < word.Length/2; i++)
                if (word[i] != reverseWord[i])
                    errors++;

            return errors < 2;
        }

        public static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double DistanceThreePoints(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            return (Distance(x1, y1, x2, y2) + Distance(x1, y1, x3, y3) + Distance(x2, y2, x3, y3)) / 3;
        }
    }
}
