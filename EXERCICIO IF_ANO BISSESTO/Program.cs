using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ano_bissesto
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOMEAR VARIÁVEIS - ANO PARA INFORME SE O ANO É BISSEXTO OU NÃO.
            int ano;

            Console.WriteLine();
            Console.WriteLine("***** INFORMAÇÕES BÁSICAS *****");
            Console.Write("\nInforme o ano desejado.....: ");
            ano = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();


            //SE O RESULTADO DA DIVISÃO DO ANO INFORMARDO, POR QUATRO, FOR IGUAL A ZERO = ANO BISSEXTO
            if ( ano %4 == 0 )
            {
                Console.WriteLine("RESULTADO....: O ANO INFORMADO É BISSEXTO");
            }

            //SE O RESULTADO DA DIVISÃO DO ANO INFORMARDO, POR QUATRO, FOR DIFERENTE DE ZERO = O ANO NÃO É BISSEXTO
            else
            {
                Console.WriteLine("RESULTADO.....: O ANO NÃO É BISSEXTO");
            }

            Console.ReadKey();


        }
    }
}
