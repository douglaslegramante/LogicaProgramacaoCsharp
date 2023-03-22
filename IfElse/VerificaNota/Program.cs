using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que leia o nome e as quatro notas de 
             * uma disciplina de um aluno e ao final escreva o nome do 
             * aluno, sua média e se ele foi aprovado, sabendo-se que
             * a média para aprovação é igual ou superior a 6.0 */

            Console.WriteLine("\t\t---Calcula Nota---\n");

            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("\nInforme a nota do 1º bimestre: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota do 2º bimestre: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota do 3º bimestre: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota do 4º bimestre: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 60.0)
            {

                Console.WriteLine("\nParabéns {0}. Sua média foi {1:n2}. \nVocê foi aprovado!", nome, media);
            }
            else Console.WriteLine("\n{0} sua nota foi {1:n2} \nVocê foi reprovado!", nome, media);

            Console.ReadKey();
        }
    }
}
