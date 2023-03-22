using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicação
            int a = 5;
            int b = 2;

            Console.WriteLine(a / b); // exibe: 2

            // convertendo o valor armazenado na variável "a"
            Console.WriteLine((double)a / b); // exibe : 2.5

            // convertendo o valor armazenado na variável "b"
            Console.WriteLine(a / (double)b); // exibe : 2.5

            // convertendo os valores armazenados nas variáveis "a" e "b"
            Console.WriteLine((double)a / (double)b); // exibe : 2.5

            //Simulação
            a = 0;
            Console.WriteLine(13 % 4); // 1
            Console.WriteLine(10 / 4); // 2
            Console.WriteLine((double)10 / 4); // 2,5
            Console.WriteLine(10 / (double)4); // 2,5
            Console.WriteLine((double)(10 / 4));
            Console.WriteLine(10.0 / a);
            Console.WriteLine(0.0 / a);
            Console.ReadKey();
            Console.WriteLine(0 / a);

            Console.ReadKey();
        }
    }
}
