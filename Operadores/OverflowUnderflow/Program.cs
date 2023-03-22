using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverflowUnderflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 2;
            Console.WriteLine(a / b);
            Console.WriteLine("Máximo valor possivel: " + a);
            Console.WriteLine("Overflow: " + (a + 2)); // overflow -2147483648
            Console.WriteLine("Minimo valor possivel: " + b);
            Console.WriteLine("Underflow: " + (b - 2)); // underflow 2147483647

            Console.WriteLine(double.MaxValue * c); // overflow: infinity (8)
            Console.WriteLine(double.MinValue * c); // overflow: -infinity (-8)
            Console.WriteLine(double.Epsilon / c); // underflow: 0.0

            Console.ReadKey();
        }
    }
}
