using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_MAIOR_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIE UM ALGORITMO QUE LEIA 5 POSIÇÕES E MOSTRE O MAIOR VALOR ENTRE ELES.


            double NUM, maior = 0, cont = 1;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n********* REGISTRO ************");
            Console.BackgroundColor = ConsoleColor.Black;
            

            while ( cont <= 5)
            {
                Console.Write("\nINFORME O {0}º NÚMERO: ", cont);
                NUM = double.Parse(Console.ReadLine());

                if (NUM > maior)
                {
                    maior = NUM++;
                }

                cont++;
            }
                        
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n********** RESULTADO **********");
            Console.WriteLine("\nO MAIOR NÚMERO => " + maior);
            Console.ReadKey();

        }
    }
}
