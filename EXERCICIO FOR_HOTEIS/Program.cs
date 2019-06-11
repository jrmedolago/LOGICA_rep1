using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_HOTEIS
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIE UM ALGORITMO QUE LEIA O NOME DO HOTEL, SUA DISTÂNCIA DO CENTRO DA CIDADE E SE O SEU ACESSO É ASFALTADO OU NÃO. EM SEGUIDA MOSTRE AS INFORMAÇÕES E A MÉDIA DE VISITANTES.

            string nome;
            int visitantes, tipoAcesso;
            double distCentro, qtdeDist = 0, totalVisitanteszero = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("\nINFORME O NOME DO {0}º HOTEL: ", i);
                nome = Console.ReadLine();

                Console.Write("INFORME A DISTANCIA DO {0}º HOTEL AO CENTRO DA CIDADE: ", i);
                distCentro = double.Parse(Console.ReadLine());

                Console.Write("INFORME A MÉDIA DE VISITANTES NO ULTIMO FERIADO: ", i);
                visitantes = int.Parse(Console.ReadLine());

                Console.Write("INFORME O TIPO DE ACESSO - 0 > Acesso não asfaltado / 1 > Acesso asfaltado: ", i);
                tipoAcesso = int.Parse(Console.ReadLine());

                Console.WriteLine("\n---------------------------------------------");
                Console.Clear();

                if (distCentro > 15)
                {
                    qtdeDist++;
                }

                if (tipoAcesso == 0)
                {
                    totalVisitanteszero = totalVisitanteszero + visitantes;
                }

                if ((tipoAcesso == 1) && (visitantes < 1000))
                {
                    Console.WriteLine("\nHOTEL {0} > distância em KM {1}", nome, distCentro);
                }

            }

            Console.WriteLine("HOTÉIS DISTANTES 15KM DO CENTRO: {0}", qtdeDist);
            Console.WriteLine("MEDIA DE VISITANTES NO ÚLTIMO FERIADO {0}", totalVisitanteszero);




            Console.ReadKey();
        }
    }
}
