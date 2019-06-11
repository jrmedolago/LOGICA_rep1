using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_VETOR_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //FAÇA UM ALGORITMO QUE RECEBE 5 ANOS DE NASCIMENTO, ARMAZENE OS VETORES, E NO FINAL MOSTRE A MÉDIA DE IDADE DOS INDIVÍDUOS

            int[] ano = new int[5];
            double idade = 0, mediaIdade, somaIdade = 0;


            for (int i = 0; i <= 4; i++)
            {
                Console.Write("INFORME O {0}º ANO: ", i + 1);
                ano[i] = int.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            for(int i=0; i <= 4; i++) { 

                idade = 2019 - ano[i];
                Console.WriteLine("\nIDADE DO {0}º: {1}", i+1, idade);

                somaIdade = somaIdade + idade;
            }

            Console.WriteLine("\n--------------------------------------");

            mediaIdade = idade / 5;

            Console.WriteLine("\nIDADE MÉDIA DOS INDIVÍDUOS: " + mediaIdade);
            Console.ReadKey();

        }
    }
}
