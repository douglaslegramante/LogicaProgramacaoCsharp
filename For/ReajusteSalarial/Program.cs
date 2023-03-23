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
            Console.WriteLine("\t\t Calcula o reajuste salarial de 10 funcionários!\n");

            // Declaração de Variáveis
            double salario, // salário do funcionário
            reajuste, // reajuste do salário do funcionário
            salarion; // novo salário do funcionário

            // Inicialização de variáveis
            reajuste = 0;
            salarion = 0;

            // Estrutura de repetição for            
            for (int cont = 1; cont <= 3; cont++)
            {
                Console.Write("Informe o salário do funcionário R$: ");
                salario = double.Parse(Console.ReadLine());

                Console.WriteLine();// Pula uma linha
                /* Verifica a situação do salário com base nas seguintes condições:
                 * Os funcionários com salário inferior a 1.000,00
                 * devem ter reajuste de 55%* Os funcionários com salário entre 1.000,00
                 * e 2.500,00 devem ter reajuste de 30%
                 * Os funcionários com salário superior a 2.500,00
                 * devem ter reajuste de 20%
                */
                if (salario < 1000)
                {
                    reajuste = (salario * 0.55);
                    salarion = salario + reajuste;
                    Console.WriteLine("O reajuste salarial foi de {0:c2} \nSeu novo salário é: R$ {1:c2}\n", reajuste, salarion);
                }
                else if (salario <= 2500)
                {
                    reajuste = (salario * 0.30);
                    salarion = salario + reajuste;
                    Console.WriteLine("O reajuste salarial foi de R$ {0:c2}  \nSeu novo salário é: R$ {1:c2}\n", reajuste, salarion);
                }
                else
                {
                    reajuste = (salario * 0.20);
                    salarion = salario + reajuste;
                    Console.WriteLine("O reajuste salarial foi de R$ {0:c2} \nSeu novo salário é: R${1:c2}\n", reajuste, salarion);

                }
            } // Fim da estrutura de repetição For
            Console.WriteLine("\tFim da execução! Precione qualquer tecla para sair.");
            Console.ReadKey();
        } // Fim do Método Main
    } // Fim da Classe
}
