using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 3, 1, 2, 4, 3, 4, 5, 6, 7, 8 };
            int[] counter = new int[arr.Length];

            int unique = 0, duplicate = 0;

            bool flag = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (arr[i] == arr[k])
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            counter[i]++;
                        }
                        flag = true;
                    }
                    
                }
                
            }

            for (int i = 0; i < arr.Length; i++)
            {
                
                if (counter[i]>0)
                {
                    Console.WriteLine("Frequency of "+arr[i]+" is "+counter[i]);
                    unique++;
                }

                if (counter[i]>1)
                {
                    duplicate++;
                }
                
            }

            Console.WriteLine("There are {0} unique values and {1} duplicate values.",unique,duplicate);
            Console.ReadLine();
        }
    }
}
