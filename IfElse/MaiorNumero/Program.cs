using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que lê três números inteiros e imprima o maior.

            Console.Write("Informe o valor de x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de z: ");
            int z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x > z) Console.WriteLine("\nO maior é X: " + x);
                else Console.WriteLine("\nO maior é Z: " + z);
            }
            else
            {
                if (y > z) Console.WriteLine("\nO maior é Y: " + y);
                else Console.WriteLine("\nO maior é Z: " + z);
            }

            Console.ReadKey();
        }
    }
}
