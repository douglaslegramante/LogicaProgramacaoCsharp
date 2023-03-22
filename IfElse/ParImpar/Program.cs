using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que verifique se um número informado é par ou impar.
            
            int n = 0;
            int r = 0;

            Console.WriteLine("\t\t---Determina se o número é par ou impar---");
            Console.Write("Informe um número: ");

            n = Convert.ToInt32(Console.ReadLine());
            r = n % 2;
            if (r == 1)
            {
                Console.WriteLine("O número informado {0} é impar", n);
            }
            else
            {
                Console.WriteLine("O número informado {0} é par", n);
            }
            Console.ReadKey();
        }
    }
}
