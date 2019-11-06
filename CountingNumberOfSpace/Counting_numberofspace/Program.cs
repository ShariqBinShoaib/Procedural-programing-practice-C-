using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_numberofspace
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string a; 
            Console.WriteLine("Enter string: ");
            a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (a.Substring(i, 1) == " ")
                {
                    count++;
                }

                //if (a[i] == ' ')
                //{
                //    count++;
                //}
            }
                Console.WriteLine(count);
            Console.ReadLine();
        }
       
    }
}
