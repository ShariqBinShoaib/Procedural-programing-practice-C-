using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, n;
            x:
            Console.Write("m = ");
            m = double.Parse(Console.ReadLine());
            Console.Write("n = ");
            n = double.Parse(Console.ReadLine());
            if (m>n)
            {
                goto x;
            }
            for (double i = m;i<=n;i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(i+" ");
                }

            }
            Console.ReadLine();
        }
    }
}
