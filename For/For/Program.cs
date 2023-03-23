using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simula a execução de um programa que gera bilhetes de loteria

            for (int numero = 1000; numero <= 1002; numero++)
            {
                Console.WriteLine("Bilhete "+numero);
            }
            Console.WriteLine("Fim!");
        }
    }
}
