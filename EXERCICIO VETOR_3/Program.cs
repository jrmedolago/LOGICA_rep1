using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_2_VETOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetor A tem 6 posições - 
            //vetor B tem 6 posições - gerar vetor b com valores invertidos

            double[] a = new double[6];
            double[] b = new double[6];
            int x = 0; 

            for (int i = 0; i <= 5; i++)
            {
                Console.Write("\nINFORME OS VALORES DO VETOR A[{0}] => ", i);
                a[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 5; i >= 0; i--)
            {
                b[x] = a[i];
                x++;
            }

            for (int i = 0; i <=5; i++)
            {
                Console.WriteLine("\nOS VALORES DO VETOR B[{0}] => {1}", i, b[i]);
            }

            Console.ReadKey();


        }
    }
}
