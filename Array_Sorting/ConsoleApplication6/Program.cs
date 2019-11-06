using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] a = { 1, 5, 7, -19, 3 };

           // for (int j = 0; j < a.Length; j++)
            for (int i = 0; i < a.Length-1; i++)
            {
                
                if (a[i] > a[i + 1])
                {
                    temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+"\t");
            }
            
            Console.ReadLine();
        }
    }
}
