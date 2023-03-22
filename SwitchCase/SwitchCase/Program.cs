using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char nota = char.Parse(Console.ReadLine());
            switch (nota)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Ótimo");
                    break;
                case 'C':
                    Console.WriteLine("Regular");
                    break;
                case 'D':
                case 'E':
                    Console.WriteLine("Ruim");
                    break;
            }

            /*
            Random rnd = new Random();
            int caseSwitch = rnd.Next(1, 4);

            switch (caseSwitch)
            {
                // The following switch section causes an error.  
                case 1:
                    //Console.WriteLine("Case 1...");
                // Add a break or other jump statement here.  
                case 2:
                    Console.WriteLine("... and/or Case 2");
                    break;
            }
            */
            Console.ReadKey();
        }
    }
}
