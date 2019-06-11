using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_SALA_DE_AULA_NOTAS_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int alunos, notas, cont = 1;
            double mediaAritmetica;

            Console.WriteLine();
            Console.Write("*************** NOTAS DS - 1B ***************");
            Console.Write("\nDIGITE O TOTAL DE ALUNOS DA SALA: ");
            alunos = int.Parse(Console.ReadLine());


            while (cont <= alunos)
            {
                Console.Write("\nDIGITE A NOTA DO {0}º ALUNO..: ", cont);
                notas = int.Parse(Console.ReadLine());


                cont++;
            }

            mediaAritmetica = notas / alunos;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\nA MÉDIA ARTMÉTICA DA CLASSE É -> ", mediaAritmetica);
            Console.ReadKey();
        }
    }
}
