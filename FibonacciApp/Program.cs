using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int num0 = 0;
            int temp = 1;

            Console.WriteLine("Aplicativo Fibonacci \n");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Valor:{num0}  \n");
                result = num0 + temp;
                num0 = temp;
                temp = result;
            }
            Console.ReadLine();
        }
    }
}
