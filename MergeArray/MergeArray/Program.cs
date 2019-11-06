using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 4, 5 };
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] mergedarray = new int[arr.Length + arr1.Length];

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                mergedarray[j] = arr[i];
                mergedarray[j + 1] = arr1[i];
                j = j + 2;
            }

            for (int i = 0; i < mergedarray.Length; i++)
            {
                Console.WriteLine(mergedarray[i]);
            }
            Console.ReadLine();
        }
    }
}
