using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoIdeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis
            string sexo, resposta;
            int opc;
            double altura, peso;

            // Inicialização de Variáveis
            peso = 0;
            resposta = "sim";

            // Estrutura para verificar se o usuário deseja continuar calculando seu peso ideal
            while (resposta == "sim" || resposta == "Sim" || resposta
                == "SIM" || resposta == "s" || resposta == "S")
            {
                // Exibe uma linha na tela
                Console.WriteLine("\t\t______________________________________________________\n");
                Console.WriteLine("\t\t\tCalcula o peso ideal de uma pessoa!!!");
                Console.WriteLine("\t\t______________________________________________________");

                // Solicita e lê o sexo de uma pessoa
                Console.Write("\nInforme o seu sexo: ");
                sexo = Console.ReadLine().ToUpper();
                //sexo = sexo.ToUpper();
                // Solicita e lê a altura de uma pessoa
                Console.Write("\nInforme sua altura: ");
                altura = double.Parse(Console.ReadLine());

                switch (sexo)
                {
                    case "MASCULINO":
                    case "M":
                        peso = (72.7 * altura) - 58;
                        Console.WriteLine("O peso ideal é de: " + peso + " Kg");
                        break;
                    case "FEMININO":
                    case "F":
                        peso = (62.1 * altura) - 44.7;
                        Console.WriteLine("O peso ideal é de: " + peso + " Kg");
                        break;
                    default: // Sexo diferente
                        Console.WriteLine("\nInforme o sexo corretamente!!!");
                        break;
                }
                // Exibe uma linha na tela
                Console.WriteLine("\t\t______________________________________________________");
                // Verifica se o usuário deseja continuar pesquisando
                Console.Write("\n\t\tDeseja continuar pesquisando?" + "\n\t\tDigite \"Sim\" para continuar: ");
                resposta = Console.ReadLine();
                // Exibe uma linha na tela
                Console.WriteLine("\t\t______________________________________________________");
                // Exibe uma linha em branco na tela
                Console.WriteLine();
                Console.Clear();

            } // Fim do while

        } // Fim do Método Main
    } // Fim da Classe
}
