using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simula a execução de um programa que gera bilhetes de loteria

            int numero = 1000;
            while (numero<=1002)
            {
                Console.WriteLine("Bilhete "+numero);
                numero++;
            }
            Console.WriteLine("Fim!");
        }
    }
}
