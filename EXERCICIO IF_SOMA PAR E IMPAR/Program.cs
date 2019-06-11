using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Bidu_22_4_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, N3, sp = 0, si = 0;

            Console.WriteLine("\n***** INFORMAÇÕES BÁSICAS *****");
            Console.Write("\nInforme o número: ");
            N1 = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o número: ");
            N2 = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o número: ");
            N3 = int.Parse(Console.ReadLine());

            if (N1 % 2 == 0)
            {
                sp = sp + N1;
            }
            else
            {
                si = si + N1;
            }

            if (N2 % 2 == 0)
            {
                sp = sp + N2;
            }
            else
            {
                si = si + N2;
            }

            if (N3 % 2 == 0)
            {
                sp = sp + N3;
            }
            else
            {
                si = si + N3;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*****R E S U L T A D O S*****");
            Console.WriteLine("\nA SOMA DOS PARES É...: " + sp);
            Console.WriteLine("\nA SOMA DOS ÍMPARES É.: " + si);
            Console.ReadKey();

        }
    }
}
