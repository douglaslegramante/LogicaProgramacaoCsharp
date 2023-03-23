using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaNumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprime e soma todos os números pares no intervalo de 49 a 149
            int soma = 0;
            string num = " ";
            for (int i = 49; i <= 149; i++)
            {
                if (i % 2 != 0)
                {
                    num += i.ToString() + "\n";
                    continue;
                }
                soma += i;
                Console.WriteLine(i);
                Console.WriteLine("Soma: " + soma);
            }
            Console.WriteLine("Numeros impares: " + num);
            Console.ReadKey();
        }
    }
}
