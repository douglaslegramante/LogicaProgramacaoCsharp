using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cond = 1;

            do
            {
                Console.WriteLine("\t\t---Calcula Média---\n\n");

                Console.Write("Informe a quantidade de alunos: ");
                int quant = int.Parse(Console.ReadLine());

                for (int a = 1; a <= quant; a++)
                {
                    double nota = 0, media = 0;
                    Console.WriteLine("\nNotas do {0}º aluno:\n", a);
                    for (int i = 1; i <= 4; i++)
                    {
                        Console.Write("Informe a nota do {0}º bimestre: ", i);
                        nota = double.Parse(Console.ReadLine());
                        media = media + nota;
                    }
                    Console.WriteLine("\nSua média é: {0}", (media / 4));
                }
                Console.Write("Deseja Calcular novamente? \n1 - Sim \n2 - Não " +
                    "\nInforme a opção: ");
                cond = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (cond == 1);
            Console.ReadKey();
        }
    }
}
