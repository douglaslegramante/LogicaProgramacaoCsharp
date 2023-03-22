using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A altura mínima para o ingresso em uma determinada atração de um 
             * parque de diversões é 0.50 metros*/

            /*
            Random gerador = new System.Random();
            int altura = gerador.Next(30,100);
            Console.WriteLine(altura);

            if (altura < 50)
            {
                Console.Write("Acesso bloqueado ");
            }
            else
            {
                Console.Write("Acesso liberado ");
            }
            Console.Write("ao Parque de Diversões");
            */


            double nota = double.Parse(Console.ReadLine());
            if (nota >= 6.0)
            {
                Console.WriteLine("Aprovado");
                if (nota < 8.0)
                {
                    Console.WriteLine("Sua nota foi regular!");
                }
                else
                {
                    Console.WriteLine("Sua nota foi ótima!");
                }
            }
            else if (nota >= 4.0)
            {
                Console.WriteLine("Exame");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            Console.WriteLine(nota.ToString("n2"));

            Console.ReadKey();
        }
    }
}
