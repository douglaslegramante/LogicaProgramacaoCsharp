using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoIdeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tendo como entrada a altura e o sexo (codificado da seguinte forma:
             * 1:feminino 2:masculino) de uma pessoa, construa um programa que
             * calcule e imprima seu peso ideal, utilizando as seguintes Fórmulas:
             * -para  homens: (72.7 * Altura) – 58
             * - para  mulheres: (62.1 * Altura) – 44.7
            */

            Console.WriteLine("\t\t---Calcula o peso ideal---");
            Console.Write("\nInforme sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme seu sexo: \n\t(1)para feminino \n\t(2)para masculino");
            int sexo = int.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                double resultado = (62.1 * altura) - 44.7;
                Console.WriteLine("\nSeu peso ideal é: {0:n2}", resultado);
            }
            else if (sexo == 2)
            {
                Console.WriteLine("\nSeu peso ideal é: {0:n2}", ((72.7 * altura) - 58));
            }
            else
            {
                Console.WriteLine("\nInforme o sexo corretamente!");
            }
            Console.ReadKey();
        }
    }
}
