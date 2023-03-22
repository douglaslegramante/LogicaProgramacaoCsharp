using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia se as medidas informadas formam um triângulo e se for, 
             * qual o seu tipo. Sendo que:
             * − Triângulo Equilátero:	possui os	3	lados iguais.
             * − Triângulo Isóscele:	possui  2	lados iguais.
             * − Triângulo Escaleno:	possui  3	lados diferentes.
             */

            // Declaração de Variáveis
            //double A, B, C; // Lados de um triângulo qualquer

            //Solicita e lê as medidas para um triângulo qualquer
            Console.Write("\tInforme o 1º lado: ");
            double A = Double.Parse(Console.ReadLine());
            Console.Write("\n\tInforme o 2º lado: ");
            double B = Double.Parse(Console.ReadLine());
            Console.Write("\n\tInforme o 3º lado: ");
            double C = Double.Parse(Console.ReadLine());
            Console.WriteLine(); // Adiciona uma linha em branco

            // Condições de existência
            /*Para construir um triângulo é necessário que a medida de qualquer um dos lados
            * seja menor que a soma das medidas dos outros dois 
            * e maior que o valor absoluto da diferença entre essas medidas.
            */
            /*
            * (b - c) < a && a < (b + c)
            * (a - c) < b && b < (a + c)
            * (a - b) < c && c < (a + b)
            * (A = B) ou (A = C) ou (B = C) ---> Triângulo Isósceles (possui os 2 lados iguais)
            * (A ? B) e (B ? C) ---> Triângulo Escaleno (possui os 3 lados diferentes)
            * (A = B) e (B = C) ---> Triângulo Equilátero (possui os 3 lados iguais)
            */

            // Verifica a condição de existência para ser um triângulo
            // Utilize chaves para mais de uma instrução (blocos deinstruções)

            //double A = 3;
            //double B = 3;
            //double C = 3;
            if (((B - C) < A && A < (B + C)) || ((A - C) < B && B < (A + C)) || ((A - B) < C && C < (A + B)))
            {
                if ((A == B) && (B == C))
                    Console.WriteLine("Triângulo Equilátero!");
                else
                {
                    if ((A == B) || (A == C) || (B == C))
                        Console.WriteLine("Triângulo Isósceles!");
                    else Console.WriteLine("Triângulo Escaleno!");
                }
            }
            else
                Console.WriteLine("\nAs medidas fornecidas não formam um triângulo!");
            Console.ReadKey();
        } // Fim do método Main
    } // Fim da clase Tipos
}
