using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_10_NUMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            //desenvolva um algoritmo que leia 5 números, mostre a soma e a média de todos.

            double num, soma = 0, media = 0, cont = 1;

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("******* INFORMAÇÕES BÁSICAS **********");
            Console.BackgroundColor = ConsoleColor.Black;

            while ( cont <= 5 )
            {
                Console.Write("\nINFORME O {0}º NUMERO: ", cont);
                num = double.Parse(Console.ReadLine());

                soma = soma + num++;



                cont++;
            }
            media = soma / 5;


            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Console.WriteLine("\n********** RESULTADOS **********");
            Console.WriteLine("\nA SOMA DOS VALORES É: {0:N}", soma);
            Console.WriteLine("\nA MEDIA DOS VALORES É: {0:N}", media);

            Console.ReadKey();

        }
    }
}
