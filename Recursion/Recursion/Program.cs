using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = factorial(5);

            Console.WriteLine(n);
        }
        


        static int factorial(int n)
        {
            Console.WriteLine("Calculating f("+n+")");

            if (n == 0)
            {
                return 1;
            }

            int f = n * factorial(n - 1);
            Console.WriteLine("f({0}) = {1} x f({2}) = {3}", n, n, n - 1, f);

            return f;
            //return n*factorial(n-1);
        }
    }
}
