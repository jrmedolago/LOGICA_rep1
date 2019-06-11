using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FATORIAL
{
    class Program
    {
        static void Main(string[] args)
        {

            // CONSTRUA UM ALGORITMO QUE LEIA UM NUMERO E CALCULE O SEU FATORIAL

            double N1, fat=1;

            Console.WriteLine("*****INFORMAÇÕES BÁSICAS*****");
            Console.Write("\nINFOME UM NUMERO QUALQUER.: ");
            N1 = double.Parse(Console.ReadLine());

            while (N1 >= 1)
            {
                fat = fat * N1;

                N1--;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\n*****RESULTADOS*****");
            Console.WriteLine("\nO FATORIAL É..: " + fat);
            Console.ReadKey();
        }
    }
}
