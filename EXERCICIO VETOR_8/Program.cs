using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_VETOR_8
{
    class Program
    {
        static void Main(string[] args)
        {

            //EM UMA FAZENDA EXISTEM 10 BOIS. ELABORE UM ALGORITMO QUE ARMAZENE O PESO DESSES BOIS EM VETOR E CALCULE: 
            //a) O BOI MAIS GORDO b) O BOI MAIS MAGRO c) A SOMA DO PESO DOS BOIS COM MAIS DE 150Kg

            double[] peso = new double[5];
            double mg = 0, mm = 500, m150 = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("\nINFORM O PESO DO {0}º BOI => ", i + 1);
                peso[i] = double.Parse(Console.ReadLine());


            }

            for (int i = 0; i <= 4; i++)
            {
                if (peso[i] < mm)
                {
                    mm = peso[i];
                }

                if (peso[i] > mg)
                {
                    mg = peso[i];
                }

                if(peso[i] > 150)
                {
                    m150++;
                }
            }
            Console.WriteLine("\nO BOI MAIS MAGRO: " + mm);
            Console.WriteLine("\nO BOI MAIS GORDO: " + mg);
            Console.WriteLine("\nBOIS ACIMA DE 150Kg: " + m150);
            

            Console.ReadKey();







        }
    }
}
