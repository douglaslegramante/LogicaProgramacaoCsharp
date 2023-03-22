using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que entre com o nome de duas pessoas e exiba
             * qual o maior nome e sua quantidade de letras */

            Console.WriteLine("\t\t---Verificar qual é o maior nome---");

            Console.Write("\nInforme o primeiro nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("\nInforme o segundo nome: ");
            string nome2 = Console.ReadLine();

            int a = nome1.Length;
            int b = nome2.Length;

            if (a > b)

                Console.WriteLine("\nCom {0} caracteres, o maior nome é: {1}", a, nome1);

            else
                Console.WriteLine("\nCom {0} caracteres, o maior nome é: {1}", b, nome2);

            Console.ReadKey();
        }
    }
}
