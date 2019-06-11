using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_PECAS
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUA UM ALGORITMO QUE:
            //LEIA O NOME, QTDE DE PARAFUSOS, PORCAS E ARRUELAS.  EM SEGUIDA 
            //CALCULE O DESCONTO SOBRE A VENDA DE PEÇAS: 20% PARAFUSOS / 10% NAS PORCAS E ARRUELAS


            string nome, parafuso, porca, arruela;
            double desc1, desc2, desc3, qtdeP, qtdePo, qtdeA, valorPa = 50, valorPo = 10, valorAr = 5, total;
            const double descP = 0.20;
            const double descPo = 0.10;
            const double descA = 0.10;


            Console.WriteLine();
            Console.WriteLine("\n******************** INFORMAÇÕES BÁSICAS ********************");
            Console.Write("\nDIGITE O NOME DO CLIENTE .....: ");
            nome = Console.ReadLine();

            Console.Write("\nDIGITE A QTDE DE PARAFUSO.....: ");
            qtdeP = double.Parse(Console.ReadLine());

            Console.Write("\nDIGITE A QTDE DE PORCA........: ");
            qtdePo = double.Parse(Console.ReadLine());

            Console.Write("\nDIGITE A QTDE DE ARRUELA......: ");
            qtdeA = double.Parse(Console.ReadLine());


            if (qtdeP > 0)
            {
                valorPa = (qtdeP * 50) * descP;
            }
            else if (qtdePo > 0)
            {
                valorPo = (qtdePo * 10) * descPo;
            }
            else if (qtdeA > 0)
            {
                valorAr = (qtdeA * 5) * descA;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("********************  RESULTADOS ********************");
            Console.WriteLine("\nNOME DO CLIENTE............: " + nome);
            Console.WriteLine("\nQTDE DE PARAFUSO...........: " + qtdeP);
            Console.WriteLine("\nPREÇO UNITARIO - PARAFUSO..: 50,00");
            Console.WriteLine("\nDESCONTO...................: {0:N}", valorPa);

            Console.WriteLine("\nQTDE DE PORCA..............: " + qtdePo);
            Console.WriteLine("\nPREÇO UNITARIO - PORCA.....: 10,00");
            Console.WriteLine("\nDESCONTO...................: {0:N}", valorPo);

            Console.WriteLine("\nQTDE DE ARRUELA............: " + qtdeA);
            Console.WriteLine("\nPREÇO UNITARIO - ARRUELA...: 50,00");
            Console.WriteLine("\nDESCONTO...................: {0:N}", valorAr);

            total = valorPa + valorPo + valorAr;
            Console.WriteLine("\nVALOR TOTAL DE VENDAS......: {0:N}", total);

            Console.ReadKey();


            



        }
    }
}
