using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;  // colocar esta using para funcionar temporizador

namespace Exercicio_contagem_de_mil
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            while (cont <= 500) //--> valor que quer exibir
            {
                Console.WriteLine(cont);
                Thread.Sleep(10); //velocidade da apresentação

                cont++;
            }
            Console.ReadKey();
        }
    }
}
