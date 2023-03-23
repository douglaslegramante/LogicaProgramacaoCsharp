using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMediaGeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis
            int N_ALUNOS, // Número de alunos
            CONT; // Contador de alunos
            double N1, N2, N3, N4, // Notas de um aluno
            MEDIA, // Média de um aluno
            MEDIAT; // Média da turma de alunos

            // Inicialização de Variáveis
            CONT = 1;
            MEDIA = 0;
            MEDIAT = 0;

            // Solicita o número de alunos
            Console.Write("Informe o número de alunos: ");
            N_ALUNOS = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (CONT <= N_ALUNOS)
            {
                // Solicita e lê as notas de um aluno
                Console.Write("\tInforme a nota do 1º Bim. do aluno {0}: ", CONT);
                N1 = Double.Parse(Console.ReadLine());
                Console.Write("\tInforme a nota do 2º Bim. do aluno {0}: ", CONT);
                N2 = Double.Parse(Console.ReadLine());
                Console.Write("\tInforme a nota do 3º Bim. do aluno {0}: ", CONT);
                N3 = Double.Parse(Console.ReadLine());
                Console.Write("\tInforme a nota do 4º Bim. do aluno {0}: ", CONT);
                N4 = Double.Parse(Console.ReadLine());
                Console.WriteLine();

                // Calcula a Média do Aluno
                MEDIA = ((N1 + N2 + N3 + N4) / 4);
                Console.WriteLine("\t\tA Média do {0}º aluno é: {1}\n", CONT, MEDIA);

                // Calcula a Média da Turma
                MEDIAT = (MEDIAT + MEDIA);
                CONT++;

            } // Fim do laço de Repetição


            // Exibe a média da turma
            Console.WriteLine("A Média geral da turma é: {0:n2}\n", MEDIAT / N_ALUNOS);
            Console.ReadKey();
        } // Fim do Método Main
    } // Fim da Classe Alunos
}
