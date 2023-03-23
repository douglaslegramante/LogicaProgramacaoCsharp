using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo;
            double soma_compras = 0;
            double compra = 0;
            int contCompra = 0;
            bool podecomprar = true;

            Console.Write("Informe o valor que tem disponivel para fazer compras: ");
            saldo = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("\nValor da compra: ");
                compra = double.Parse(Console.ReadLine());

                if (compra > 0)
                {
                    if (compra <= saldo)
                    {
                        saldo = saldo - compra;
                        soma_compras = soma_compras + compra;
                        contCompra++;
                        Console.WriteLine("\nPode Comprar - Saldo disponivel: {0:c2}", saldo);
                    }
                    else
                    {
                        podecomprar = false;
                        Console.WriteLine("\nJá não pode comprar - Saldo insuficiente");
                    }
                }
                else
                {
                    Console.WriteLine("\nValor tem que ser positivo");
                }
            } while (podecomprar);
            Console.WriteLine("\nNúmero de Compras: {0}\nTotal gasto: {1:c2} \nSaldo que sobrou: {2:c2}", contCompra, soma_compras, saldo);
            Console.ReadKey();
        }
    }
}
