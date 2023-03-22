using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Valores booleanos podem ser invertidos com o operador de negação !
            double d = 4;

            /*podemos verificar se uma variável do tipo double armazena um valor
             * maior do que 5 de duas formas diferentes*/

            //verifica diretamente
            Console.WriteLine(d > 5);

            //utiliza o operador de negação
            Console.WriteLine(!(d > 5));

            Console.ReadKey();
        }
    }
}
