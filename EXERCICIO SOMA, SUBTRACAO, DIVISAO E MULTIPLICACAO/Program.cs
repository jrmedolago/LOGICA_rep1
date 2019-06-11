using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //dados referentes as operações entre o primeiro e o segundo numero

            double num1, num2, soma, subtracao, multiplicacao, divisao;
            

            Console.WriteLine();
            Console.Write("Digite o primeiro número da equação...: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo número da equação....: ");
            num2 = double.Parse(Console.ReadLine());
            

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("*****RESULTADOS*****");

            soma = (num1 + num2);
            Console.WriteLine("\nSoma..........: " + soma);

            subtracao = (num1 - num2);
            Console.WriteLine("\nSubtração.....: " + subtracao);

            multiplicacao = (num1 * num2);
            Console.WriteLine("\nMultiplicação.: " + multiplicacao);

            divisao = (num1 / num2);
            Console.WriteLine("\nDivisão.......: {0:N}", + divisao);
            Console.ReadKey();

        }
    }
}
