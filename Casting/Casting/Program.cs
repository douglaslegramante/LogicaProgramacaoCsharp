using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Conversão implícita
             * podemos copiar diretamente qualquer valor armazenado 
             * em uma variável do tipo int para uma variável do tipo long
             */
            double a = 3.1415;
            int b = (int)a;//casting
                           //Console.WriteLine(b);

            // não podemos copiar diretamente um valor armazenado 
            // em uma variável do tipo long para uma variável do tipo int
            long c = 25;
            int d = (int)c;

            /*Conversão explícita
             * Para copiar o valor armazenado em uma variável para outra variável de um tipo incompatível, 
             * é necessário realizar uma operação de casting.
             */
            long e = 4294967296; //3000000000;
            int f = (int)e; // f = -1294967296
                            //int suporta valores de -2147483648 a 2147483647

            // Um cast é uma maneira de informar explicitamente ao compilador que você 
            // pretende fazer a conversão e que você está ciente de que poderá ocorrer perda de dados

            Console.WriteLine("o valor de f é: " + f);
            Console.ReadKey();
        }
    }
}
