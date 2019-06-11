using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_BIDU_13_05_219
{
    class Program
    {
        static void Main(string[] args)
        {


            int sexo, olhos, cabelo, idade;
            int maiorIdade = 0, qtdeFem = 0, QtdeLoiroVerde = 0;

            Console.Write("Digite a Idade..: ");
            idade = int.Parse(Console.ReadLine());

            while (idade > 0)
            {
                Console.Write("Digite o Sexo (1 MASC / 2 FEM): ");
                sexo = int.Parse(Console.ReadLine());

                Console.Write("Digite a cor dos olhos (1 AZUL / 2 VERDE / 3 CASTANHO: ");
                olhos = int.Parse(Console.ReadLine());

                Console.Write("Digite a cor do cabelo (1 LOIRO / 2 CASTANHO / 3 PRETO): ");
                cabelo = int.Parse(Console.ReadLine());

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }

                if ((sexo == 2) && (idade >=18) && (idade <= 35))
                {
                    qtdeFem++;
                }

                if ((olhos == 2) && (cabelo == 1)){
                    QtdeLoiroVerde++;
                }

                Console.Write("Digite a Idade..: ");
                idade = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("A MAIOR IDADE -> {0}", maiorIdade);
            Console.WriteLine("MUHLHERES COM IDADE ENTRE 18 e 35 ANOS -> {0}", qtdeFem);
            Console.WriteLine("INDIVIDUOS LOIRO(A)S DE OLHOS VERDES -> {0}", QtdeLoiroVerde);
            Console.ReadKey();
        }
    }
}
