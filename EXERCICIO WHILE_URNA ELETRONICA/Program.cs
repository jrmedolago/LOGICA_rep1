using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Una_Eletronica
{
    class Program
    {
        static void Main(string[] args)
        {
            //ELABORA UM ALGORITMO QUE REALIZE UMA VOTAÇÃO: CANDIDATO 11, 22 E 33. 
            //EM SEGUIDA MOSTRA A QTDE DE VOTOS PARA CADA CANDIDATO E A PORCENTAGEM DE CADA UM COM RELAÇÃO AO TOTAL DE VOTOS.

            int voto, vn = 0, vb = 0, c11 = 0, c22 = 0, c33 = 0;
            double pc11 = 0, pc22 = 0, pc33 = 0, pn = 0, pb = 0;
            int cont = 1;


                        

            while (cont <= 10) {

                Console.WriteLine("\n****** ELEIÇÕES NAVAL 2019 *****");
                Console.WriteLine("CANDIDATO - 11");
                Console.WriteLine("CANDIDATO - 22");
                Console.WriteLine("CANDIDATO - 33");
                Console.WriteLine("---------------------");
                Console.WriteLine();
                Console.Write("DIGITE SEU VOTO: ", cont);
                voto = int.Parse(Console.ReadLine());
                Console.Clear();

            
                if (voto == 11)
                {
                    c11++;
                }

                else if (voto == 22)
                {
                    c22++;
                }
                
                else if (voto == 33)
                {
                    c33++;
                }

                else if (voto == 0)
                {
                    vb++;
                }

                else
                {
                    vn++;
                }


                cont++;
            }

            pc11 = (c11 * 100) / 10;
            pc22 = (c22 * 100) / 10;
            pc33 = (c33 * 100) / 10;
            pb = (vb * 100) / 10;
            pn = (vn * 100) / 10;

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("**********RESULTADO ELEIÇÕES NAVAL 2019**********");
            Console.WriteLine("\nVOTOS CANDIDATO 11 - {0}, {1:N}%", c11, pc11);
            Console.WriteLine("\nVOTOS CANDIDATO 22 - {0}, {1:N}%", c22, pc22);
            Console.WriteLine("\nVOTOS CANDIDATO 33 - {0}, {1:N}%", c33, pc33);
            Console.WriteLine("\nVOTOS BRANCOS - {0}, {1:N}%", vb, pb);
            Console.WriteLine("\nVOTOS NULOS - {0}, {1:N}%", vn, pn);
                       

            Console.ReadKey();



        }
    }
}
