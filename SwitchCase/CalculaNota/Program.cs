using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Caucula Nota do Aluno\n");
            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a nota do 1º bimestre: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Informe a nota do 2º bimestre: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("Informe a nota do 3º bimestre: ");
            int nota3 = int.Parse(Console.ReadLine());
            Console.Write("Informe a nota do 4º bimestre: ");
            int nota4 = int.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            char conceito = '0';

            if (media >= 90.0)
            {
                conceito = 'A';
            }
            else if (media >= 80.0)
            {
                conceito = 'B';
            }
            else if (media >= 60.0)
            {
                conceito = 'C';
            }
            else if (media >= 40.0)
            {
                conceito = 'D';
            }
            else if (media >= 20)
            {
                conceito = 'E';
            }

            switch (conceito)
            {
                case 'A':
                    Console.WriteLine("\nParabéns {0}! Você foi Aprovado com o conceito '{1}'", nome, conceito);
                    break;
                case 'B':
                    Console.WriteLine("\nParabéns {0}! Você foi Aprovado com o conceito '{1}'", nome, conceito);
                    break;
                case 'C':
                    Console.WriteLine("\nParabéns {0}! Você foi Aprovado com o conceito '{1}'", nome, conceito);
                    break;
                case 'D':
                    Console.WriteLine("\n{0} seu conceito é '{1}' Você está de Recuperação", nome, conceito);
                    break;
                case 'E':
                    Console.WriteLine("\n{0} seu conceito é '{1}' Você está de Exame", nome, conceito);
                    break;

                default:
                    Console.WriteLine("\n{0} você foi Reprovado!", nome);
                    break;
            }
            Console.ReadKey();
        }
    }
}
