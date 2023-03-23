using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis
            int NUM, CONT, TAB;

            // Inicialização de Variáveis
            CONT = 1;
            TAB = 0;

            // Solicita e lê o número fornecido pelo usuário
            Console.Write("Informe o número desejado: ");
            NUM = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Estrutura de repetição while executando a tabuada
            while (CONT <= 10)
            {
                TAB = NUM * CONT;
                Console.WriteLine("{0} X {1} = {2}", NUM, CONT, TAB);
                //CONT = CONT + 1;
                CONT++;
            }

            Console.ReadKey();
        } // Fim do Método Main
    } // Fim da Classe Números
}
