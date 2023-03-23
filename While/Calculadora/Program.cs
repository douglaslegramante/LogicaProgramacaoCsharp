using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            double NUM1, NUM2, RESULTADO;
            int OPC;
            string RESPOSTA;
            // Inicialização de Variáveis
            RESULTADO = 0;
            RESPOSTA = "SIM";
            // Verifica se o usuário deseja continuar calculando
            while (RESPOSTA == "SIM" || RESPOSTA == "S")
            {
                // Exibe uma linha na tela
                Console.WriteLine("\t\t\t\tCalculadora simples!!!");
                Console.WriteLine("\t\t______________________________________________________");

                // Solicita e lê dois números informados pelo usuário
                Console.Write("\n\t\tInforme o 1º número: ");
                NUM1 = Double.Parse(Console.ReadLine());
                Console.Write("\t\tInforme o 2º número: ");
                NUM2 = Double.Parse(Console.ReadLine());

                // Solicita e lê o operador matemático para efetuar o cálculo
                Console.Write("\n\t\tQual operação matemática você deseja efetuar ? " +
                "\n\n\t\t\t\t1 - Adição" + "\n\t\t\t\t2 - Subtração" + "\n\t\t\t\t3 - Divisão" +
                "\n\t\t\t\t4 - Multiplicação" + "\n\t\t\t\t5 - Exponenciação" +
                "\n\n\t\tInforme a opção: ");
                OPC = Int32.Parse(Console.ReadLine());

                // Estrutura de seleção switch
                switch (OPC)
                {
                    case 1: // Adição
                        RESULTADO = NUM1 + NUM2;
                        MessageBox.Show("O resultado é: " + RESULTADO, "Calculando a soma",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        break;
                    case 2: // Subtração
                        RESULTADO = NUM1 - NUM2;
                        MessageBox.Show("O resultado é: " + RESULTADO, "Calculando a subtração", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        break;
                    case 3: // Divisão
                        RESULTADO = NUM1 / NUM2;
                        MessageBox.Show("O resultado é: " + RESULTADO, "Calculando a divisão", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        break;
                    case 4: // Multiplicação
                        RESULTADO = NUM1 * NUM2;
                        MessageBox.Show("O resultado é: " + RESULTADO, "Calculando a multiplicação", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                        break;
                    case 5: // Exponenciação
                        RESULTADO = Math.Pow(NUM1, NUM2);
                        MessageBox.Show("O resultado é: " + RESULTADO, "Calculando a Exponenciação", MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                        break;
                    default: // Considera outras opções
                        MessageBox.Show("Opção inválida!!! " + RESULTADO, "Tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                } // Fim do switch
                  // Exibe uma linha na tela
                Console.WriteLine("\t\t______________________________________________________");
                // Efetua novas pesquisas dependendo do resultado informado pelo usuário
                Console.Write("\n\t\tVocê deseja continuar?" + "\tDigite \"SIM\" para continuar: ");
                RESPOSTA = Console.ReadLine().ToUpper();// Exibe uma linha na tela
                Console.WriteLine("\t\t______________________________________________________");
                Console.Clear();
                // Exibe uma linha em branco na tela
                Console.WriteLine();
            } // Estrutura de repetição while
        } // Fim do método Main
    } // Fim da classe
}