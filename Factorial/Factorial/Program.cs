using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }
        static int factorial(int x)
        {
            int a = 1;
            for (int i = 1; i <= x; i++)
            {
                a = a * i;
            }
            return a;
        }
    }
}
