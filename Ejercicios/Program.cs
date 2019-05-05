using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios.Polymorphism;

namespace Ejercicios
{  
    class Program
    {
        static void Main(string[] args)
        {

            //var stopwatch = new StopWatch();
            //Console.WriteLine(Entrevistas.distanciaTresPuntos(-3, 0, 3, 0, 6, 0));
            //Console.WriteLine(Entrevistas.IsAlmostPalindromic("acbcc"));
            //Console.WriteLine(Entrevistas.IsAlmostPalindromic("acbca"));
            //Console.WriteLine(Entrevistas.MostPopularNum(new int[] { 1, 1, 1, 4, 4, 4, 2, 2, 2 }, 9));
            /*
            var stack = new Stack();
            stack.Push("dddddd");
            stack.Push(DateTime.Now);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            */

            DbCommand comando = new DbCommand(new SqlConnection("dss"), "instruction" );
            comando.Execute();
            DbCommand comando2 = new DbCommand(new OracleConnection("daa"), "insdddtruction" );
            comando2.Execute();
        }
    }
}
