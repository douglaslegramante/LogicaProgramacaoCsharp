using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeAutomatica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Máquina de Café Automática---");
            Console.WriteLine("\nMenu:");
            Console.WriteLine(" \t1 = Café expresso curto");
            Console.WriteLine(" \t2 = Café expresso longo");
            Console.WriteLine(" \t3 = Café com pouco leite");
            Console.WriteLine(" \t4 = Capuccino");
            Console.WriteLine(" \t5 = Capuccino com chocolate");
            Console.WriteLine(" \t6 = Chocolate");
            Console.WriteLine(" \t7 = Chocolate com leite");
            Console.WriteLine(" \t8 = Leite");
            Console.WriteLine(" \t9 = Leite macchiato");
            Console.WriteLine(" \t10 = Chá");

            Console.Write("\nPor favor informe o código da bebida desejada: ");
            byte cod = byte.Parse(Console.ReadLine());
            int custo = 0;

            switch (cod)
            {
                case 1:
                    custo += 5;
                    break;
                case 2:
                    custo += 7;
                    break;
                case 3:
                    custo += 7;
                    break;
                case 4:
                    custo += 8;
                    break;
                case 5:
                    custo += 12;
                    break;
                case 6:
                    custo += 6;
                    break;
                case 7:
                    custo += 9;
                    break;
                case 8:
                    custo += 4;
                    break;
                case 9:
                    custo += 6;
                    break;
                case 10:
                    custo += 3;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Código inválido. Por favor informe o código correto.");
                    break;
            }
            if (custo != 0)
            {
                Console.Clear();
                Console.WriteLine("Por favor, insira {0:c2}", custo);
                Console.WriteLine("\nObrigado pelo seu trabalho! Tenha um bom dia.");
            }
            Console.ReadKey();
        }
    }
}
