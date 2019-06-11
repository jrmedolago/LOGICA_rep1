using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um algoritmo que leia um vetor A de 15 posições:
            //A) a soma dos numeros do vetor com indice par
            //B) a soma dos numeros do vetor com indice impar
            //C) a qtde de número pares e a qtde de numeros impares

            double somaPar = 0, somaImpar = 0, qtdePar = 0, qtdeImpar = 0;
            double[] A = new double[5];

            Console.WriteLine("********** DADOS DE VETOR **********");


            for (int i = 0; i <= 4; i++)
            {
                Console.Write("\nINFORME OS VALORES DE A{0} = ", i + 1);
                A[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 4; i++)
            {
                if (i % 2 == 0)
                {
                    somaPar = somaPar + A[i];
                }
                else
                {
                    somaImpar = somaImpar + A[i];
                }

                if (A[i] % 2 == 0)
                {
                    qtdePar++;
                }
                else
                {
                    qtdeImpar++;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("********** RESULTADOS **********");

            Console.WriteLine("\nA SOMA DOS NUMEROS COM INDICE PAR É => "+ somaPar);
            Console.WriteLine("A SOMA DOS NUMEROS COM INDICE IMPPAR É => "+ somaImpar);

            Console.WriteLine("\nA QTDE DE NUMEROS PARES É => "+ qtdePar);
            Console.WriteLine("A QTDE DE NUMEROS IMPARES É => "+ qtdeImpar);


            Console.ReadKey();
        }
    }
}
