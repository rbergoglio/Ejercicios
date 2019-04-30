using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            var stopwatch = new StopWatch();
            Console.WriteLine(Entrevistas.distanciaTresPuntos(-3, 0, 3, 0, 6, 0));
            Console.WriteLine(Entrevistas.NumMasPopular(new int[] { 1, 1, 1, 4, 4, 4, 2, 2, 2 }, 4));
        }
    }
}
