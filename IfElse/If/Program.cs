using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A altura mínima para o ingresso em uma determinada atração de um 
             * parque de diversões é 0.50 metros*/

            Random gerador = new System.Random();
            int altura = gerador.Next(30, 100);
            Console.WriteLine(altura);

            if (altura >= 50)
            {
                Console.WriteLine("Venda permitida");
            }

            //Console.WriteLine("Venda não permitida");

            Console.ReadKey();
        }
    }
}
