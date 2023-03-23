using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaNumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprime e soma todos os números impares no intervalo de 1 a 100
            int soma = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                soma += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Soma: " + soma);
            Console.ReadKey();
        }
    }
}
