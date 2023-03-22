using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicação
            int i = 10;
            Console.WriteLine(i > 100 & i++ < 500);
            Console.WriteLine(i > 100 && i++ < 500);
            Console.WriteLine(i > 0 | i++ < 500);
            Console.WriteLine(i > 0 || i++ < 500);
            Console.WriteLine(i);

            //Simulação
            int a = 2;
            int b = 10;

            Console.WriteLine(a > 0 || b < 0);
            Console.WriteLine(a == 2 && b != 10);
            Console.WriteLine(a <= 0 ^ b >= 1);

            Console.ReadKey();

        }
    }
}
