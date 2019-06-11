using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_VETOR3
{
    class Program
    {
        static void Main(string[] args)
        {
            //INFORME DOIS VETORES INTEIROS DE 10 POSIÇÕES, SOME-OS E ARMAZENE EM UM TERCEIRO VETOR
            int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];

            for (int i = 0; i <=9; i++)
            {
                Console.Write("INFORME O {0}º VALOR DE VETOR A = ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine();

            for (int i = 0; i <=9; i++)
            {
                Console.Write("INFORME O {0}º VALOR DE VETOR B = ", i + 1);
                B[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n---------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            for (int i = 0; i <= 9; i++)
            {
                C[i] = A[i] + B[i];
                Console.WriteLine("A SOMA DO {0}º VETOR É => {1}", i + 1, C[i]);                
            }

            Console.ReadKey();


        }
    }
}
