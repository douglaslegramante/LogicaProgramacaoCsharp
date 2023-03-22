using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicação
            int valor = 2;
            bool b;

            b = (valor == 2); // b = true
            Console.WriteLine(b);
            b = (valor != 2); // b = false
            Console.WriteLine(b);
            b = (valor < 2); // b = false
            Console.WriteLine(b);
            b = (valor <= 2); // b = true
            Console.WriteLine(b);
            b = (valor > 1); // b = true
            Console.WriteLine(b);
            b = (valor >= 1); // 

            //Simulação
            int a = 1;

            Console.WriteLine(a == 1);
            Console.WriteLine(a > 5);
            Console.WriteLine(a <= 3);

            Console.ReadKey();
        }
    }
}
