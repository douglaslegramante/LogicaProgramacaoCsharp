using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaDoisNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compara dois números e verifica qual o maior, menor e se são iguais ou diferentes.
            // Exibe uma linha na tela
            Console.WriteLine("\t\t---Compara 2 números quaisquer!---");

            // Declaração e Inicialização de Variáveis
            double num1, num2; // Dois números a serem fornecidos pelo usuário
            string opc;
            string resposta = "sim".ToUpper();

            // Verifica se o usuário deseja continuar a comparação entre os dois números
            while (resposta == "SIM" || resposta == "S")
            {
                // Solicita e lê os números a serem fornecidos pelo usuário
                Console.Write("\nInforme o 1º número: ");
                num1 = Double.Parse(Console.ReadLine());
                Console.Write("Informe o 2º número: ");
                num2 = Double.Parse(Console.ReadLine());
                Console.Write("\nO que você deseja fazer?" +
                    "\n\t1 - Verificar o maior número fornecido ? " +
                    "\n\t2 - Verificar o menor número fornecido ? " +
                    "\n\t3 - Verificar se os números são iguais ? " +
                    "\n\nInforme sua opção: ");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1": // Verifica qual o maior número
                        if (num1 > num2)
                            Console.WriteLine("\n\tO número {0} é o maior número!", num1);
                        else
                            Console.WriteLine("\n\tO número {0} é o maior número!", num2);
                        break;
                    case "2": // Verifica qual o menor número
                        if (num1 < num2) Console.WriteLine("\n\tO número {0} é o menor número!", num1);
                        else
                            Console.WriteLine("\n\tO número {0} é o menor número!", num2);
                        break;
                    case "3": // Verifica se os números são iguais ou diferentes
                        if (num1 == num2)
                            Console.WriteLine("\n\tOs números {0} e {1} são iguais!!!", num1, num2);
                        else
                            Console.WriteLine("\n\tOs números {0} e {1} são diferentes!!!", num1, num2);
                        break;
                    default: // Verifica as outras possíveis opções
                        Console.WriteLine("\n\tOpção inválida!!!");
                        break;
                }
                Console.Write("\nVocê deseja continuar?" +
                "\n\tDigite \"Sim\" para continuar a pesquisa:");
                resposta = Console.ReadLine().ToUpper();
                Console.Clear();
            } // Fim do while
            Console.ReadKey();
        } // Fim do Método Main
    } // Fim da classe Compara
}
