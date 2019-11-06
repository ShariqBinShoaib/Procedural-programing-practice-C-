using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_casesofletter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int x;

            Console.WriteLine("Enter string: ");
            s = Console.ReadLine();
            Console.WriteLine();

            char[] c = new char[s.Length];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                x = s[i];
                if (x > 64 && x < 91)
                {
                    x += 32;
                    count++;
                }
                else if (x > 96 && x < 123)
                {
                    x -= 32;
                    count++;
                }

                c[i] = (char) x;
                Console.Write(c[i]);
            }
            Console.WriteLine("\n\nTotal no. of cases changed = " +count);
            Console.ReadLine();
        }
    }
}
