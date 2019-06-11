using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_divisivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;

            Console.WriteLine();
            Console.WriteLine("\n************** INFORMAÇÕES **************");
            Console.Write("\nDIGITE UM NÚMERO QUALQUER..: ");
            n1 = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            
            if (n1 % 2 == 0)
            {
                Console.WriteLine("\nO NUMERO INFORMADO É PAR");
            }

            else
            {
                Console.WriteLine("\nO NÚMERO INFORMADO É IMPAR");
            }
            Console.ReadKey();



        }
    }
}
