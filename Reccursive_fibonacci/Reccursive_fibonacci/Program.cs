using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reccursive_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = fibonacci(2);
            Console.WriteLine(n);
        }


        static int fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }

        }
    }
}
