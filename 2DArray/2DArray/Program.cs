using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];

            Console.WriteLine("Enter the data of 1st matrix: ");
            for (int i = 0; i <  3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the data of 2nd matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                if (i == 1)
                {
                    Console.Write("+\t");
                }
                else
                {
                    Console.Write("\t");
                }
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                if (i == 1)
                {
                    Console.Write("=\t");
                }
                else
                {
                    Console.Write("\t");
                }
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
