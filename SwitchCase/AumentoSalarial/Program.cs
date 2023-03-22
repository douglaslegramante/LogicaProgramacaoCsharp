using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aumento de salário de acordo com o cargo

            double novoSalario;
            int cargo;
            double salario;

            Console.WriteLine("\t\t---Calcula Aumento Salarial---");
            Console.WriteLine("Cargos: \n\t1 = gerente \n\t2 = engenheiro \n\t3 = técnico");
            Console.Write("\nPor favor informe o cargo: ");
            cargo = int.Parse(Console.ReadLine());

            Console.Write("Informe o salario: ");
            salario = double.Parse(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    novoSalario = salario + (0.1 * salario);
                    break;
                case 2:
                    novoSalario = salario + (0.2 * salario);
                    break;
                case 3:
                    novoSalario = salario + (0.3 * salario);
                    break;
                default:
                    novoSalario = salario + (0.4 * salario);
                    break;
            }

            Console.WriteLine("\nSalario antigo= " + salario.ToString("c2") + "\nNovo salario= "
                + novoSalario.ToString("c2") + "\nValor do Reajuste= "
                + (novoSalario - salario).ToString("c2"));
            Console.ReadKey();
        }
    }
}
