using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            {
                for (int i = n; i >= 1; i--)
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write("      @");
                    }
                    Console.WriteLine();
                }

                for (int k = 1; k >= n; k++)
                {
                    for (int j = 1; j >= k; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
