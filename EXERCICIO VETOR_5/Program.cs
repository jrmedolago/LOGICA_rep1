using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_3_VETOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //DESENVOLVA UM ALGORITMO QUE LEIA UM VETOR DE 20 POSIÇÕES E INFORME:
            //A) QTOS NÚMEROS SÃO MAIORES QUE 50;
            //B) QTOS NUMEROS SÃO MENORES QUE 7;

            double[] a = new double[5];
            int maior50 = 0, menor7 = 0;


            for (int i = 0; i <= 4; i++)
            {
                Console.Write("\nINFORME O {0}º VALOR DO VETOR => ", i +1);
                a[i] = double.Parse(Console.ReadLine());

            }

            for (int i = 0; i <= 4; i++)
            {
                if (a[i] > 50)
                {
                    maior50++;
                }

                if (a[i] < 7)
                {
                    menor7++;
                }

            }

            Console.WriteLine("\nNUMEROS MAIORES QUE 50 => " + maior50);
            Console.WriteLine("\nNUMEROS MENORES QUE 07 => " + menor7);
            Console.ReadKey();

        }
    }
}
