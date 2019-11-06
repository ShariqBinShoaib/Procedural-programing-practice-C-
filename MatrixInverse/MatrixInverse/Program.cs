using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace MatrixInverse
{
    class Program
    {
        static void Main(string[] args)
        {
            double divisor = 0, multiplier = 0;

            Console.WriteLine("*****MATRIX INVERSE*****\n");

            Console.Write("Enter number of Rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int col = row;

            double[,] matrix = new double[row, col];
            double[,] identity = new double[row, col];

            Console.WriteLine("\nEnter data of matrix\n");
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("Row # " + (i + 1));
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j)
                        identity[i, j] = 1;
                    else
                        identity[i, j] = 0;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nIdentity Matrix:\n");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(identity[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nInitial Matrix:\n");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int count = 0;
            for (int k = 0; k < 2 * row; k++)
            {
                if (k % 2 == 0 && k > 0)
                {
                    count++;
                }

                for (int i = 0; i < row; i++)
                {
                    divisor = matrix[i, i];
                    multiplier = matrix[i, count];
                    for (int j = 0; j < col; j++)
                    {
                        if (k % 2 == 0)
                        {
                            if (i == count)
                            {
                                matrix[i, j] /= divisor;
                            }
                        }
                        else
                        {
                            if (i != count)
                            {
                                matrix[i, j] -= multiplier * matrix[count, j];
                            }
                        }

                    }

                }

                Console.WriteLine("\nIteration # {0}:\n", k + 1); 

                for (int l = 0; l < row; l++)
                {
                    for (int m = 0; m < col; m++)
                    {
                        Console.Write(matrix[l, m] + "\t");
                    }
                    Console.WriteLine();
                }


            }

            Console.WriteLine("\nReduced Matrix:\n");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}