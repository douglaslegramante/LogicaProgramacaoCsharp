using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia o salario atual e calcule e exiba o 
             * salário reajustado de acordo com a seguinte regra: Salário até 1500, 
             * reajuste de 23%; Salários maiores que 1500, reajuste de 18%. */

            Console.WriteLine("\t\t---Reajuste de Salário---");

            Console.Write("\nInforme o salário atual: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario <= 1500)
            {
                Console.WriteLine("\nSeu salário será reajustado para: {0:c2}", (salario * 0.23) + salario);
            }
            else
                Console.WriteLine("\nSeu salário será reajustado para: {0:c2}", (salario * 0.18) + salario);

            Console.ReadKey();
        }
    }
}
