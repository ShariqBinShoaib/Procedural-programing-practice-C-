using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars

{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j,k;
            n = 5;

            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= i; j--)
                    Console.Write(" ");

                for (k = 1; k <= i; k++)
                    Console.Write("* ");

                Console.WriteLine();
            }

            Console.WriteLine();
            for (i = 1; i <= n; i++)
             {
                 for (j = i; j <= n; j++)
                     Console.Write(" ");

                 for (k = i; k >= 1; k--)
                     Console.Write("* ");

                 Console.WriteLine();
             }

            Console.ReadLine();

        }
    }
}
