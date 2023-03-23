using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que simule uma conta corrente: 
             * ela possui um saldo e você pode depositar ou sacar valores dela 
             */

            string op,
               continua = "s".ToUpper();
            decimal saldo = 0,
                    deposito = 0,
                    saque = 0;

            while (true)//(continua == "S" || continua == "SIM")
            {
                Console.WriteLine("\t\t---Banco Digital---\n");
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("\t1 - Depositar");
                Console.WriteLine("\t2 - Sacar");
                Console.WriteLine("\t3 - Consultar Saldo");
                Console.WriteLine("\t4 - Sair");

                Console.Write("\nInforme a opção desejada: ");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("\nInforme o valor do depósito: ");
                        deposito = decimal.Parse(Console.ReadLine());
                        if (deposito > 0)
                        {
                            saldo = saldo + deposito;
                            Console.WriteLine("\tDepósito Realizado com Sucesso!\n\tSeu saldo é de {0:c2}", saldo);
                        }
                        else
                        {
                            Console.WriteLine("Valor Inválido! Informe um valor maior que R$ 0,00");
                            goto case "1";
                        }
                        break;
                    case "2":
                        Console.Write("\nInforme o valor do saque: ");
                        saque = decimal.Parse(Console.ReadLine());
                        if (saque > 0 && saque <= saldo)
                        {
                            saldo = saldo - saque;
                            Console.WriteLine("\tSaque Realizado com Sucesso!\n\tSeu saldo é de {0:c2}", saldo);
                        }
                        else
                        {
                            Console.WriteLine("\tSaque fora do limite permitido!\n\tSeu saldo é de {0:c2}", saldo);
                            goto case "2";
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nSeu saldo é de {0:c2}", saldo);
                        break;
                    case "4":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("\nOpção Inválida! Informe uma opção válida!");
                        break;
                }
                //Console.WriteLine("\nDeseja realizar outra operação?\n\t[S]im\n\t[N]ão");
                //continua = Console.ReadLine().ToUpper();
                Console.WriteLine("Precione qualquer tecla para continuar!");
                Console.ReadKey();
                Console.Clear();
            }
            //Console.ReadKey();
        }
    }
}
