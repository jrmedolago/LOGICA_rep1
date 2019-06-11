using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_comissao_venda
{
    class Program
    {
        static void Main(string[] args)
        {

            //CRIE UM ALGORITMO PARA CALCULAR A COMISSÃO DE VENDA DE IMOVEL, PARA 3 CORRETORES, ONDE: 
            //A) VENDAS ATÉ 300000 - 7% / 
            //B) VENDAS DE 300000 A 500000 - 9,5% / 
            //C) VENDAS ACIMA DE 500000 - 12%

            string nome1, nome2, nome3;
            double totalVendas, vendaC1, vendaC2, vendaC3, vrComissao1, vrComissao2, vrComissao3;
            
            Console.WriteLine();
            Console.WriteLine("***************** INFORMAÇÕES BÁSICAS *****************");
            Console.Write("\nINFORME O NOME DO CORRETOR 1.....: ");
            nome1 = Console.ReadLine();

            Console.Write("\nINFORME A VENDA DO CORRETOR 1....: ");
            vendaC1 = double.Parse(Console.ReadLine());
            

            Console.Write("\nINFORME O NOME DO CORRETOR 2.....: ");
            nome2 = Console.ReadLine();

            Console.Write("\nINFORME A VENDA DO CORRETOR 2....: ");
            vendaC2 = double.Parse(Console.ReadLine());


            Console.Write("\nINFORME O NOME DO CORRETOR 3.....: ");
            nome3 = Console.ReadLine();

            Console.Write("\nINFORME A VENDA DO CORRETOR 3....: ");
            vendaC3 = double.Parse(Console.ReadLine());


            if (vendaC1 > 50000) //vendedor 1
            {
                vrComissao1 = vendaC1 * 0.12;
            }
            else if (vendaC1 >= 30000)
            {
                vrComissao1 = vendaC1 * 0.095;
            }
            else
            {
                vrComissao1 = vendaC1 * 0.07; 
            }


            if (vendaC2 > 50000) //vendedor 2
            {
                vrComissao2 = vendaC2 * 0.12;
            }
            else if (vendaC2 >= 30000)
            {
                vrComissao2 = vendaC2 * 0.095;
            }
            else
            {
                vrComissao2 = vendaC2 * 0.07;
            }


            if (vendaC3 > 50000) //vendedor 3
            {
                vrComissao3 = vendaC3 * 0.12;
            }
            else if (vendaC3 >= 30000)
            {
                vrComissao3 = vendaC3 * 0.095;
            }
            else
            {
                vrComissao3 = vendaC3 * 0.07;
            }


            totalVendas = vendaC1 + vendaC2 + vendaC3;


            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n***************** RESULTADOS *****************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nNOME DO CORRETOR 1.........: " + nome1);
            Console.WriteLine("\nVENDAS CORRETOR 1..........: {0:N}", + vendaC1);
            Console.WriteLine("\nCOMISSAO DO CORRETOR.......: {0:N}", + vrComissao1);

            Console.WriteLine("\nNOME DO CORRETOR 2.........: " + nome2);
            Console.WriteLine("\nVENDAS CORRETOR 2..........: {0:N}", + vendaC2);
            Console.WriteLine("\nCOMISSAO DO CORRETOR.......: {0:N}", + vrComissao2);

            Console.WriteLine("\nNOME DO CORRETOR 3.........: " + nome3);
            Console.WriteLine("\nVENDAS CORRETOR 3..........: {0:N}", + vendaC3);
            Console.WriteLine("\nCOMISSAO DO CORRETOR.......: {0:N}", + vrComissao3);

            Console.WriteLine("\n***********************************************");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nTOTAL DE VENDAS DA EMPRESA.: {0:N}", + totalVendas);

            Console.ReadKey();

        }
    }
}
