using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exibe uma linha na tela
            Console.WriteLine("\n\t\t Calcula o reajuste salarial de um funcionário!!!");
            Console.WriteLine("\t\t______________________________________________________\n");

            // Declaração de Variáveis
            char cargo; // cargo do funcionário
            double salario, // salário mensal do funcionário
            salariof = 0; // salário reajustado do funcionário
            string resposta = "SIM";

            // Estrutura de repetição while para verificar a iteração com o usuário
            while (resposta == "sim" || resposta == "SIM" || resposta == "Sim" || resposta == "S" || resposta == "s")
            {
                // Solicita e lê o salário do funcionário
                Console.Write("\n\t\tInforme o valor do salário do funcionário: R$ ");
                salario = Double.Parse(Console.ReadLine());

                // Apresenta os cargos da empresa
                Console.Write("\n\t\tDigite: " + "\n\t\t\tT - Técnico - reajuste de 50 % "
                + "\n\t\t\tG - Gerente - reajuste de 30%" +
                "\n\t\t\tO - Outros - reajuste de 20%"
                + "\n\n\t\t\tInforme a opção: ");

                // Lê o cargo do funcionário
                cargo = Char.Parse(Console.ReadLine());

                // Estrutura de seleção múltipla switch para verificar o cargo selecionado
                switch (cargo)
                {
                    case 't': // Reajuste salarial de 50%
                    case 'T':
                        salariof = salario + (salario * 0.50);
                        Console.WriteLine("\n\t\t\tO salário reajustado do Técnico é de: R$ {0}", salariof);
                        break;
                    case 'g': // Reajuste salarial de 30%
                    case 'G':
                        salariof = salario + (salario * 0.30);
                        Console.WriteLine("\n\t\t\tO salário reajustado do Gerente é de: R$ {0}", salariof);
                        break;
                    case 'o': // Reajuste salarial de 20%
                    case 'O':
                        salariof = salario + (salario * 0.20);
                        Console.WriteLine("\n\t\t\tO salário reajustado do funcionário é de: R$ {0}", salariof);
                        break;
                    default: // Considera todas os outros caracteres
                        Console.WriteLine("Opção inválida! Por favor digite uma opção válida!");
                        break;
                }
                // Verifica se o usuário deseja continuar fazendo a pesquisa
                Console.Write("\n\t\tDeseja continuar? Informe \"Sim\" para continuar: ");
                resposta = Console.ReadLine();
                Console.Clear();
            }
            // Exibe uma linha na tela
            Console.WriteLine("\t\t______________________________________________________");
            // Exibe uma linha em branco na tela
            Console.WriteLine();

        } // Fim do Método Main
    } // Fim da Classe
}