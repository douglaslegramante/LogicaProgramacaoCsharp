using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Potenciação
            Console.WriteLine(Math.Pow(2, 3)); // exibe 8


            double x = 25;
            double y = 9;
            double total = Math.Pow(x, y);
            Console.WriteLine(total.ToString("n2"));

            //Raiz Quadrada
            Console.WriteLine(Math.Sqrt(144)); // exibe 7
                                               //O método Sqrt devolve NaN quando é aplicado a valores negativos.

            Console.ReadKey();
        }
    }
}
