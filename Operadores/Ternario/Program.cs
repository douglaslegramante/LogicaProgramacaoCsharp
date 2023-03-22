using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gerar a nota de um aluno aleatoriamente
            Random gerador = new Random();
            int nota = gerador.Next(0, 100);

            //Console.Write("Digite a nota do aluno: ");
            //double nota = double.Parse(Console.ReadLine());
            /* O programa deve exibir a mensagem “aprovado” se nota de um aluno for m
             * maior ou igual a 60 e “reprovado” se a nota for menor do que 60 */

            // condição ? expressão1_se_true : expressão2_se_false

            //if (nota >= 60)
            //{
            //    Console.WriteLine("Aprovado");
            //}
            //else
            //{
            //    Console.WriteLine("Reprovado");
            //}

            //string resultado = nota >= 60 ? "Aprovado" : "Reprovado";

            Console.WriteLine(nota);
            //Console.WriteLine(resultado);
            Console.WriteLine(nota >= 60 ? "Aprovado" : "Reprovado");
            //Console.WriteLine(nota.ToString("n2"));

            Console.ReadKey();
        }
    }
}
