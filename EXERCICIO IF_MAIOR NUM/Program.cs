using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_25_03
{
    class Program
    {
        static void Main(string[] args)
        {

            //CONSTRUA UM ALGORITMO QUE LEIA 2 NUMEROS E INDIQUE O MAIOR DELES.

            int N1, N2;

            Console.WriteLine();
            Console.Write("Informe o primeiro número...: ");
            N1 = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o segundo número....: ");
            N2 = int.Parse(Console.ReadLine());


            Console.Clear();
            
            Console.WriteLine();
            Console.WriteLine("***** R E S U L T A D O *****");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            if (N1 > N2)
            {
                Console.WriteLine("O NUMERO MAIOR É.....: " + N1);
            }

            else
            {
                Console.WriteLine("O NUMERO MAIOR É.....: " + N2);
            }
            Console.ReadKey();
                        
        }
    }
}
