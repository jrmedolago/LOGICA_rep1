using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_JOICE_LUPINO
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome, frase;
            double AnoNascimento, AnoAtual, Resultado, Resultado2, Resultado3, AnoIdadeIrmao, Resultado4, Resultado5;

            //resultado 1 refere-se aos anos de vida; o resultado2 refere-se aos dias, e o resultado3 refere-se as horas vividas
            //resultado4 refere-se a diferença de idade entre vc e o irmão
            //resultado5 refere-se a quantidade de dias vividos da diferença entre sua idade e de seu irmão.

            Console.Write("\nDigite seu nome completo: ");
            nome = Console.ReadLine();

            Console.Write("\nInforme o ano de seu nascimento: ");
            AnoNascimento = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o ano atual: ");
            AnoAtual = double.Parse(Console.ReadLine());

            Console.Write("\n Informe a idade de seu irm(ã)o mais velho(a): ");
            AnoIdadeIrmao = double.Parse(Console.ReadLine());

            Console.Write("\nDigite uma frase de seu gosto: ");
            frase = Console.ReadLine();

            Resultado  = (AnoAtual - AnoNascimento);
            Resultado2 = (AnoAtual - AnoNascimento) * 365;
            Resultado3 = (Resultado2 * 24);
            Resultado4 = (AnoIdadeIrmao - Resultado);
            Resultado5 = (Resultado4 * 365);
            //aqui temos os cálculos no ano, dias e horas vividas

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\n************* RESULTADOS *************");
            Console.WriteLine();
            Console.WriteLine(nome + " \nvocê tem - " + Resultado + " anos, " + Resultado2 + " dias, " + Resultado3 + " horas de vida até agora");

            Console.WriteLine("\nVocê tem - " + Resultado4 + " anos a menos que seu irm(ã)o, ou " + Resultado5 + " dias a menos, de vida, que Ele(a)");

            Console.WriteLine("\nSua frase: " + frase + " - contém " + frase.Length + " caracteres");
            //aqui temos a contagem de caracteres da

            Console.WriteLine("\nSua frase a partir do 10 caracter é: " + frase.Substring(10, frase.Length - 10));

            Console.WriteLine("\nOBRIGADO POR SUA CONTRIBUIÇÃO!");
            Console.ReadKey();


        }
    }
}
