using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_VETOR_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //ESCREVE UM ALGORITMO QUE LEIA UM VETOR COM 10 POSIÇÕES DE NUMEROS INTEIROS, EM SEGUIDA, 
            //RECEBE UM NOVO VALOR DO USUÁRIO E VERIFIQUE SE ESTE VALOR SE ENCONTRA NO VETOR

            int[] num = new int[5];
            int num2;

            Console.WriteLine("***** D A D O S *****");

            for(int i = 0; i <=4; i++)
            {
                Console.Write("\nINFORME O {0}º NÚMERO: ", i + 1);
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.Clear();

            Console.Write("\nINFORME UM NÚMERO = ");
            num2 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;

            for(int i = 0; i <=4; i++)
            {
                if(num2 == num[i])
                {
                    Console.WriteLine("\nO VALOR INFORMADO ENCONTRA-SE NOS REGISTROS NA POSIÇÃO = " + i);
                }

            }

            Console.WriteLine("\nVALORES DOS VETORES");
            for (int i = 0; i<=4; i++)
            {
                Console.WriteLine("VETOR [{0}] = {1}", i, num[i]);
            }
            Console.ReadKey();


        }
    }
}
