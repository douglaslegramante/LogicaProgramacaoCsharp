using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicação
            int valor = 1;

            valor = valor + 2; // valor = 3

            valor = valor - 1; // valor = 2

            valor = valor * 6; // valor = 12

            valor = valor / 3; // valor = 4

            valor = valor % 3; // valor = 1

            valor = valor + 1; // valor = 2

            valor = valor - 1; // valor = 1
            Console.WriteLine(valor);

            //Simulação
            int a = 7;
            a += 3;
            a *= 2;
            a++;
            a -= 2;
            Console.WriteLine(a);
            Console.WriteLine(+1 + " Aula POO");//
            Console.WriteLine(-1);//
            Console.ReadKey();
        }
    }
}
