using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "pneumoultramicroscopicossilicovulcanoconiótico"; //maior palavra da língua portuguesa

            //A propriedade Length devolve a quantidade de caracteres (comprimento) de uma string.
            int espacos = s.Length;
            Console.WriteLine(espacos);

            //Podemos acessar um determinado caractere de uma string através do operador []
            char a = s[0]; // obtém o primeiro caractere
            char b = s[14]; // obtém o décimo quinto caractere
            char c = s[40]; // obtém o quadragésimo caractere

            Console.WriteLine(a); // exibe : p
            Console.WriteLine(b); // exibe : r
            Console.WriteLine(c); // exibe : i

            /*O método Contains verifica se uma determinada sequência de 
            caracteres está contida em uma string*/
            bool resultado1 = s.Contains("co");
            bool resultado2 = s.Contains("Co");

            Console.WriteLine(resultado1); // exibe : True
            Console.WriteLine(resultado2); // exibe : False

            /*O método EndsWith verifica se uma string termina 
            com uma determinada sequência de caracteres*/
            bool resultado3 = s.EndsWith("ótico");
            bool resultado4 = s.EndsWith("cano");

            Console.WriteLine(resultado3); // exibe : True
            Console.WriteLine(resultado4); // exibe : False

            /*O método StartsWith verifica se uma string começa com uma 
            determinada sequência de caracteres*/
            bool resultado5 = s.StartsWith("micro");
            bool resultado6 = s.StartsWith("pneu");

            Console.WriteLine(resultado5); // exibe : False
            Console.WriteLine(resultado6); // exibe : True

            //Podemos realizar substituições em uma string com o método Replace
            string s1 = "Matamos o tempo, o tempo nos enterra"; // Machado de Assis

            s1 = s1.Replace("o tempo", "um coveiro");

            Console.WriteLine(s1); // exibe : Matamos um coveiro , um coveiro nos enterra

            //É possível extrair um trecho de uma string com o método Substring
            string s2 = "Porta corta fogo";

            string s3 = s2.Substring(9);
            Console.WriteLine(s3); // exibe : ta fogo

            string s4 = s2.Substring(6, 5); // a => posição de inicio b => quantidade de caracteres
            Console.WriteLine(s4); // exibe : corta

            //O método ToUpper transforma em maiúsculas todas as letras contidas em uma string
            string s5 = "ifro - Instituto Federal de Rondonia";
            string s6 = s5.ToUpper();
            Console.WriteLine(s6); // exibe : IFRO - INSTITUTO FEDERAL DE RONDONIA


            //O método ToLower transforma em minúsculas todas as letras contidas em uma string
            string s7 = "IFRO - Instituto Federal de Rondonia";
            string s8 = s7.ToLower();
            Console.WriteLine(s8); // exibe : ifro - instituto federal de rondonia

            //O método Trim elimina os espaços em branco do começo e do término de uma string
            string s9 = "    IFRO Campus Vilhena    ";
            string s10 = s9.Trim();
            Console.WriteLine(s10); // exibe : IFRO Campus Vilhena

            string data = "13/03/2019";
            string[] date = data.Split('/');
            Console.WriteLine("Dia: " + date[0]);
            Console.WriteLine("Mês: " + date[1]);
            Console.WriteLine("Ano: " + date[2]);
            Console.ReadKey();
        }
    }
}
