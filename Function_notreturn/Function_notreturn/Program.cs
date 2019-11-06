//Functions:
//Return a value

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_notreturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Shariq();
            Test();
            Table(4);
            Add(7,8);
        }
        static void Shariq()
        {
                Console.WriteLine("This is Shariq");
        }
        static void Test()
        {
            Console.WriteLine("This is test function");
        }
        static void Table(int x)
        {
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(x + " x " + i + " = " + (x * i));
            }
        }
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
