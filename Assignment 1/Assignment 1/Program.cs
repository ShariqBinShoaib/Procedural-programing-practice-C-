using System;

namespace Assignment_1
{
    class Program
    {
        public static void Main()
        {
            float a, b, fact = 1, d = 0;
            Console.WriteLine("Enter a number: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                fact = fact * b;
                d += b / fact;
            }
            Console.WriteLine(+a+"! = " + fact);
            for (int i = 1; i<= a; i++)
            {
                Console.Write("(" + i + "/" + i + "!)+");
            }
            Console.WriteLine(" = " + d );
        }
    }
}
