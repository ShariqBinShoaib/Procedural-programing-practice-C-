using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            y:
                int num;
                Console.Write("Enter a binary number: ");
                num = Convert.ToInt32(Console.ReadLine());

                int count = digitcounter(num);
                Console.WriteLine("\nNumber of digits: " + count);

                int[] a = new int[count];
                double sum = 0;

                for (int i = 0; i < count; i++)
                {
                    a[i] = num % 10;
                    num = num / 10;
                if (a[i] < 0 || a[i] >1)
                {
                    Console.WriteLine("\nInvalid input!\nPlease enter a correct binary number\n");
                        goto y;
                }
                    sum = (a[i] * Math.Pow(2, i)) + sum;
                }

                Console.Write("Binary Number: ");
                for (int i = count - 1; i >= 0; i--)
                {
                    Console.Write(a[i] + " ");
                }

                Console.WriteLine("\nDecimal Number: " + sum);
           
                Console.ReadLine();
        }

        static int digitcounter(int n)
        {
            int count=0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }

            return count;
        }

        
    }
}
