using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("********** TABUADA **********");

            Console.Write("\nDIGITE A TABUADA DESEJADA: ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-----------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", N, i, N * i);
            }

            Console.ReadKey();
        }
    }
}
