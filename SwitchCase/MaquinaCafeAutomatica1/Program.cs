using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeAutomatica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Máquina de Café Automática---");
            Console.WriteLine("\nTamanhos de café: \n\t1 = pequeno \n\t2 = medio \n\t3 = grande");
            Console.Write("\nPor favor informe o tamanho: ");
            string str = Console.ReadLine();
            int cost = 0;

            // Because of the goto statements in cases 2 and 3, the base cost of 25
            // cents is added to the additional cost for the medium and large sizes.
            switch (str)
            {
                case "1":
                case "pequeno":
                    cost += 3;
                    break;
                case "2":
                case "medio":
                    cost += 2;
                    goto case "1";
                case "3":
                case "grande":
                    cost += 2;
                    goto case "1";
                default:
                    Console.WriteLine("Tamanho inválido. Por favor, selecione 1, 2, ou 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Por favor, insira {0:c2}", cost);
            }
            Console.WriteLine("\nObrigado pelo seu trabalho! Tenha um bom dia.");
            Console.ReadKey();

            // O exemplo exibe a saída como:
            //         Tamanhos de café: 1 = pequeno 2 = médio 3 = grande
            //         Por favor digite sua seleção: 2
            //         Por favor, insira R$ 5,00.
            //         Obrigado! Tenha um bom dia.
        }
    }
}
