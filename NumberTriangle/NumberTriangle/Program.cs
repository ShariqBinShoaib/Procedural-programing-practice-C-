using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j<= i; j++)
                {
                    if (j == n)
                    {
                        break;
                    }
                    Console.Write(j);
                }
                for (int j = n*2-2; j >= i*2; j--)
                {
                    Console.Write("*");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
