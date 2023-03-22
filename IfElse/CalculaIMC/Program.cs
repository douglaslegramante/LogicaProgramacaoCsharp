using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcula o IMC com base nos dados informados
            double altura, peso, imc;

            Console.WriteLine("\t\t---Calculo de IMC---");

            Console.Write("\nInforme seu peso (em kg): ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Informe sua altura (em metros): ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("\nSeu IMC é {0:n2}. Abaixo do peso ideal!", imc);
            }
            else if (imc >= 18.5 && imc < 25.0)
            {
                Console.WriteLine("\nSeu IMC é {0:n2}. Peso ideal, parabéns!", imc);
            }
            else if ((imc >= 25.0) && (imc < 30.0))
            {
                Console.WriteLine("\nSeu IMC é {0:n2}. Levemente acima do peso ideal!", imc);
            }
            else if ((imc >= 30.0) && (imc < 35.0))
            {
                Console.WriteLine("\nSeu IMC é {0:n2}. Obesidade grau I", imc);
            }
            else if ((imc >= 35.0) && (imc < 40.0))
            {
                Console.WriteLine("\nSeu IMC é {0:n2}. Obesidade grau II (severa)", imc);
            }
            else if (imc >= 40.0)
            {
                Console.WriteLine("\nSeu IMC é {0:n2}. Obesidade grau III (mórbida)", imc);
            }
            Console.ReadKey();
        }
    }
}
