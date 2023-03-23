using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 189 Slide

            int dec;
            int f1, f2, c;

            Console.Write("Informe a maior temperatura em Fahrenheit: ");
            f1 = int.Parse(Console.ReadLine());
            Console.Write("Informe a menor temperatura em Fahrenheit: ");
            f2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de decremento: ");
            dec = int.Parse(Console.ReadLine());

            for (; f1 >= f2; f1 = f1 - dec)
            {
                c = 5 * (f1 - 32) / 9;
                Console.WriteLine("\nTemperatura em graus Celsius: {0}", c);
            }

            Console.ReadKey();
        }
    }
}
