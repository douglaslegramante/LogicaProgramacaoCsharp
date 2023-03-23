using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamanhoNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 220 Slide
            string nome;
            int tam;

            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();
            tam = nome.Length;

            for (int i = 1; i <= tam; i++)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}
