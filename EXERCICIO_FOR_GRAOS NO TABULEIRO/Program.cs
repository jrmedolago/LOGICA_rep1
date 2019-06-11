using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_RAINHA
{
    class Program
    {
        static void Main(string[] args)
        {
            //DESENVOLVA UM ALGORITMO QUE MOSTRE A QUANTIDADE TOTAL DE GRÃOS NUM TABULEIRO DE XADREZ DE 64 POSIÇÕES, SABENDO-SE QUE A PARTIR DA SEGUNDA CASA A QTDE DE GRÃOS DOBRAM.


            double totalGraos = 1, somaGraos = 0;
            int i;

            Console.WriteLine();
            Console.WriteLine("********** DADOS COLHEITA **********");
            Console.WriteLine("\nCALCULAR O TOTAL DE GRÃOS");

            for (i = 1; i <= 64; i++)
            {

                if (i > 1)
                {
                    totalGraos = totalGraos * 2;
                }
                
                Console.WriteLine("\nCasa {0} = {1:N0}", i, totalGraos);
                somaGraos = somaGraos + totalGraos;
                                            
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\nTOTAL GERAL = {0:n0}", somaGraos);

            Console.ReadKey();
        }
    }
}
