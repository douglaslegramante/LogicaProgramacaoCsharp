using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Jogo de dados no qual o jogador ganha quando a soma dos números obtidos
             * em lançamentos consecutivos de um dado ultrapassar um determinado valor.
             * 
             * A instrução break interrompe os lançamentos 
             * se o valor desejado for ultrapassado.
             */

            int soma = 0;
            Random gerador = new Random();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Lançamento: " + i);

                int numero = gerador.Next(1, 6);
                Console.WriteLine("Número: " + numero);
                soma += numero; // soma = soma + numero
                Console.WriteLine("Soma: " + soma);
                Console.WriteLine("");
                if (soma > 3)
                {
                    Console.WriteLine("Você ganhou com " + i + " lançamentos");
                    break;
                }
            }
            Console.WriteLine("Jogue Novamente!");

            Console.ReadKey();
        }
    }
}
