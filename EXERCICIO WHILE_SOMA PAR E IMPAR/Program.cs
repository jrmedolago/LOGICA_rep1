using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_contador_22_4_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIE UM ALGORITMO QUE LEIA 5 OU MAIS POSIÇÕES; SOME OS PARES E OS IMPARES E MOSTRE NA TELA.


            int num, sp = 0, si = 0, cont = 1;

            Console.WriteLine("\n***** INFORMAÇÕES BÁSICAS *****");

            while (cont <= 3)
            {
                Console.Write("\nINFORME O NUMERO..: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    sp = sp + num;
                }
                else
                {
                    si = si + num;
                }
                cont++;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***** R E S U L T A D O S *****");
            Console.WriteLine("\nA SOMA DOS PARES É.....: " + sp);
            Console.WriteLine("\nA SOMA DOS IMPARES É.....: " + si);
            Console.ReadKey();
        }
    }
}
