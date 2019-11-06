using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamund
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n,i,j,k;
            n = 10;

            for (i = 1; i <= n; i++)
            {
                for (j = i; j >= 1; j--)
                    Console.Write(" ");


                for (k = 1; k <= i; k++)
                    Console.Write("* ");

                Console.WriteLine();
            }

         /*   for (i = 1; i <= n; i++)
             {
                 for (j = 1; j <=i; j++)
                     Console.Write(" ");

                 for (k = n; k > i; k--)
                     Console.Write(" *");

                 Console.WriteLine();
             }*/

            Console.ReadLine();
        }
    }
}
