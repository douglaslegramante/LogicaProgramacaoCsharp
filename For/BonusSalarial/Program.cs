using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exibe uma linha na tela
            Console.WriteLine("\t\t\tCalcula o bônus salarial!!!\n");

            // Declaração de variáveis
            double salario, // salário do funcionário
            reajuste, // reajuste salarial do funcionário (bônus)
            montante; // total dos bônus aplicados aos 10 funcionários
            int cont_anos; // tempo que o funcionário atua na empresa em anos
            string sexo; // sexo do funcionário(a)

            // Inicialização de Variáveis
            reajuste = 0;
            montante = 0;

            // Estrutura de repetição for
            for (int cont = 1; cont <= 10; cont++)
            {
                // Solicita e lê o sexo do funcionário(a)
                // Lendo um valor do tipo string
                Console.Write("Informe o sexo do funcionário(a): ");
                sexo = Console.ReadLine();
                sexo = sexo.ToUpper();

                // Solicita e lê o valor do salário do funcionário(a)
                // Lendo um valor do tipo double
                Console.Write("\nInforme o salário do funcionário(a):R$ ");
                salario = Double.Parse(Console.ReadLine());

                // Solicita e lê a quantidade de tempo de casa do funcionário(a)
                // Lendo um valor do tipo int
                Console.Write("\nInforme o quantidade de anos trabalhados na empresa: ");
                cont_anos = Int32.Parse(Console.ReadLine());
                // Pula uma linha
                Console.WriteLine();
                /* Verifica a condição em que se enquadra o salário do
                * funcionário(a)* para o tempo de serviço executado na empresa,
                * conforme a seguinte tabela:
                * Os funcionários do sexo masculino com tempo de casa
                * superior a 15 anos terão
                * direito a um bônus de 20% do seu salário;
                * As funcionárias com tempo de casa superior a 10
                * anos terão direito a um bônus
                * de 25% do seu salário;
                * Os demais funcionários terão direito a um bônus de
                R$ 1.000,00
                */
                if ((sexo == "MASCULINO") || (sexo == "M") && (cont_anos > 15))
                {
                    reajuste = (salario * 0.20);
                    Console.WriteLine("O reajuste salarial do funcionário foi de: R${ 0}\n", reajuste);
                }
                else
                {
                    if ((sexo == "FEMININO") || (sexo == "F") && (cont_anos > 10))
                    {
                        reajuste = (salario * 0.25);
                        Console.WriteLine("O reajuste salarial da funcionária foi de: R${ 0}\n", reajuste);
                    }
                    else
                    {
                        reajuste = 1000.00;
                        Console.WriteLine("O reajuste salarial da funcionário(a) foi de: R${ 0}\n", reajuste);
                    }
                }
                // Calcula o montante (total de bônus) gasto com os funcionários
                montante = montante + reajuste;
            } // Fim do laço de repetição for
              // Exibe o resultado
            Console.WriteLine("O montante gasto com os funcionários(as) foi de: R$ {0}", montante);
            // Exibe uma linha na tela
            Console.WriteLine("\t\tFim da execução! Precione qualquer tecla para sair.");
            Console.ReadKey();
        } // Fim do método Main
    } // Fim da classe Bônus
}
