using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertElementinArray
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: " );
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine("Enter the elements of array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }

            Console.WriteLine("\nEnter the element and its index respectively:");
            int elem = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[arr.Length + 1];
            int count = 0;
            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i == index)
                    arr1[i] = elem;
                else arr1[i] = arr[count++];
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+"\t");
            }

            Console.ReadLine();
        }
    }
}
