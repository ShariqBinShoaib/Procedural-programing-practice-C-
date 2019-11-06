//Functions:
//Return value

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_returnvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Add(4, 2);
            Console.WriteLine(a + 10);
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            return x+y;
        }
       static double Factorial(double y)
        {
            double a = 1;
            for (int i = 1; i <= y; i++)
            {
                a = a * i;
            }
            return a;
        }
        

    }
}
