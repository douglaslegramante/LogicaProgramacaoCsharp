using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernarioNegacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota = 5.99999999;
            bool reprovado = !(nota >= 6);
            string s = reprovado ? "REPROVADO" : "APROVADO";

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
