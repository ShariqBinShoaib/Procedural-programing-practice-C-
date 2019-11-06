using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            for (int i = 0; i <= n; i++)
            {
                for (int j = n; j >= i+i; j--)
                {
                    Console.Write(" ");
                }
                

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
