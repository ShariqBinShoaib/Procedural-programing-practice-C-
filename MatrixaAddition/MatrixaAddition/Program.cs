using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixaAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] MatrixA = new int[4, 4];
            //int[,] MatrixB = new int[4, 4];
            //int[,] MatrixC = new int[4, 4];

            //for (int r = 0; r < 4; r++)
            //    for (int c = 0; c < 4; c++)
            //    {
            //        MatrixA[r, c] = 1;
            //        MatrixB[r, c] = 1;
            //    }

            //for (int r =0; r<4; r++)
            //    for (int c = 0; c<4; c++)
            //    {
            //        MatrixC[r, c] = MatrixA[r, c] + MatrixB[r, c];
            //    }

            //for (int r = 0; r < 4; r++)
            //{
            //    for (int c = 0; c < 4; c++)
            //    {
            //        Console.Write(" " + MatrixC[r, c]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            int[,] MatrixA = new int[4, 4];
            int[,] MatrixB = new int[4, 4];
            int[,] MatrixC = new int[4, 4];

            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    MatrixA[r, c] = r;
                    MatrixB[r, c] = c;
                }
            }


            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                   
                    Console.Write(" " + MatrixA[r, c]);
                }
                Console.Write(" ");
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(" " + MatrixB[r, c]);
                  }



                Console.WriteLine();
            }
            Console.WriteLine();

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                {
                    MatrixC[r, c] = MatrixA[r, c] + MatrixB[r, c];
                }

            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(" " + MatrixC[r, c]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(MatrixC[i, i]);

            }
            Console.ReadLine();

        }


        }
    
}
