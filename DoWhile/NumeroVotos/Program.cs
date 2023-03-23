using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroVotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Verifica o número de votos para os candidatos a melhor série de TV, 
                         * contabilizando o número de votos brancos e nulos.*/

            // Declaração e Inicialização de Variáveis
            int nvcand1 = 0, // número de votos do candidato 1
            nvcand2 = 0, // número de votos do candidato 2
            nvcand3 = 0, // número de votos do candidato 3
            nvbrancos = 0, // número de votos em branco
            nvnulos = 0, // número de votos nulos
            neleitores = 0, // número de total votantes
            opc; // Opção para o eleitor escolher no menu
            string resposta = "sim".ToUpper();
            string mensagem = "\n";

            // Estrutura de repetição do/while
            do
            {
                // Exibe a data e hora!
                Console.WriteLine("Data: " + DateTime.Now);

                // Exibe uma linha na tela
                Console.WriteLine("\n\t\t---Qual é a melhor série de todos os tempos?---");

                // Solicita e lê a opção do usuário
                Console.Write("\nInforme sua opção: \n\t1 - The Big Bang Theory" +
                    "\n\t2 - Game of Thrones" + "\n\t3 - Supernatural" +
                    "\n\t4 - Outra" + "\n\t5 - Não sabe!!!" + "\n\nA opção é: ");
                opc = int.Parse(Console.ReadLine());

                // Estrutura de seleção múltipla
                switch (opc)
                {
                    case 1:
                        nvcand1++;
                        break;
                    case 2:
                        nvcand2++;
                        break;
                    case 3:
                        nvcand3++;
                        break;
                    case 4:
                        nvbrancos++;
                        break;
                    case 5:
                        nvnulos++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                } // Fim do switch

                // Verifica se o usuário deseja continuar votando
                Console.Write("\n\tVoto realizado com sucesso! \n\tDeseja depositar outro voto?, digite \"[S]im\" para prosseguir: ");
                resposta = Console.ReadLine().ToUpper();
                Console.Clear();
            } while (resposta == "SIM" || resposta == "S");

            // Calcula o número de eleitores
            neleitores = nvcand1 + nvcand2 + nvcand3 + nvbrancos + nvnulos;
            mensagem += "The Big Bang Theory = " + nvcand1 + "\n"
            + "Game of Thrones = " + nvcand2 + "\n"
            + "Supernatural = " + nvcand3 + "\n"
            + "Outras = " + nvbrancos + "\n"
            + "Não conhece = " + nvnulos + "\n";

            Console.WriteLine("\t\t---Resultado da votação---");
            // Exibe o total de eleitores
            Console.WriteLine("\nO número total de votos é: " + neleitores);
            // Exibe o total de votos por candidato
            Console.WriteLine("\nTotal de votos por opção: \n" + mensagem);
            Console.WriteLine("\nPressione qualquer tecla para sair!");
            Console.ReadKey();
        } // Fim do Método Main
    } // Fim da Classe Urnas
}
