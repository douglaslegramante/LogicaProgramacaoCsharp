using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementoDecremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicação
            int a = 10;
            // pós incremento
            Console.WriteLine(a++ == 10); // exibe : true
            Console.WriteLine(a); // exibe : 11

            int b = 10;
            // pré incremento
            Console.WriteLine(++b == 10); // exibe : false
            Console.WriteLine(b); // exibe : 11

            //Simulação
            a = 7;
            b = 12;
            Console.WriteLine(a++ == 7 || b++ == 12);
            Console.WriteLine(++a <= 9 && --b == 12);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(1 + 2 + 3 + " testando ");
            Console.WriteLine(" testando " + 1 + 2 + 3);

            Console.WriteLine('a' + 'a');

            Console.ReadKey();
        }
    }
}
