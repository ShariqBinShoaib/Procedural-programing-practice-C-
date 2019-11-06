using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] array = new int[5,5];
            //for (int row = 0; row < 5; row++)
            //{
            //    Console.WriteLine();
            //    for (int col = 0; col < 5; col++)
            //    {
            //        Console.Write(" " + row + "," + col);
            //    }
            //}
            //Console.ReadLine();


            //int[,] array = new int[5, 5];
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        array[row, col] = col;
            //    }
            //}

            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        Console.Write(" " +array[row,col]+ " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            int[,] array = new int[5, 5];
            for (int row = 0; row < 5; row++)
            {
                //int temp = 0;
                for (int col = 0; col < 5; col++)
                {
                    array[row, col] = row*col;
                    //temp += 2;
                }
            }

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(array[row,col]+ "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
