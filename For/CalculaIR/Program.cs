using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 234 Slide
            string nome;
            double salario, ir;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\tInforme o nome: ");
                nome = Console.ReadLine();
                Console.Write("\tInfrome o salário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario < 1000)
                {
                    ir = 0.0;
                }
                else if (salario < 1500)
                {
                    ir = salario * 0.075;
                }
                else
                {
                    ir = salario * 0.15;
                }
                Console.WriteLine("\n{0} o valor de IR a ser pago sobre o seu salário é de {1:c2}", nome, ir);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
