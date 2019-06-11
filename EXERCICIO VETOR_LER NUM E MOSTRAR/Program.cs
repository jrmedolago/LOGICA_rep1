using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //INFORME UM ALGORITMO ONDE O USUÁRIO INFORMA 10 VALORES QUE FICAM ARMAZENADOS EM UM VETOR. 
            //APÓS ARMAZENÁ-LOS RECUPERAR OS VALORES.

            double[] numero = new double[5];

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n*********** DADOS BÁSICOS ***********");
            Console.BackgroundColor = ConsoleColor.Black;

            for (int i=0; i <=4; i++)
            {
                Console.Write("\nINFORME O {0}º NUMERO: ", i + 1);
                numero[i] = double.Parse(Console.ReadLine());
            }


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------RESULTADO----------------");

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("\nVETOR NUMERO[{0}] = {1}", i, numero[i]);
            }

            Console.ReadKey();


        }
    }
}
