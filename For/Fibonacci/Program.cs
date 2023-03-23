using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 208 Slide

            int ant = 0,
                atual = 1,
                prox;

            for (int i = 0; i < 10; i++) ;
            {
                Console.WriteLine("\n" + atual);
                prox = ant + atual;
                ant = atual;
                atual = prox;
            }

            Console.ReadKey();
        }
    }
}
