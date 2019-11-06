using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, sum1 = 0, sum2 = 0;
            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];

            for (int i = 0; i < 4; i++)
            {
                jagged[0][i] = i;
            }

            for (int i = 0; i < 3; i++)
            {
                jagged[1][i] = i;
            }

            for (int i = 0; i < 5; i++)
            {
                jagged[2][i] = i;
            }

            for (int i = 0; i<4; i++)
            {
                sum = jagged[0][i] + sum;
                Console.Write(jagged[0][i]);
            }
            Console.WriteLine("\t" + sum);

            for (int i = 0; i < 3; i++)
            {
                sum1 = jagged[1][i] + sum1;
                Console.Write(jagged[1][i]);
            }
            Console.WriteLine("\t" + sum1);

            for (int i = 0; i < 5; i++)
            {
                sum2 = jagged[2][i] + sum2;
                Console.Write(jagged[2][i]);
            }
            Console.WriteLine("\t" + sum2);
            Console.ReadLine();
        }
    }
}
