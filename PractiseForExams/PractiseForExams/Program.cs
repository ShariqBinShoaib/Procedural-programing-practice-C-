using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseForExams
{
    class Program
    {
        static void Main(string[] args)
        {
            //---DIAMOND---

            /*byte n = 10;
            for (byte j = 0; j < n; j++)
            {
                for (byte i = n; i > j; i--)
                {
                    Console.Write(" ");
                }

                for (byte i = 0; i <= j*2; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (byte j = 0; j <= n; j++)
            {
                for (byte i = 0; i < j; i++)
                {
                    Console.Write(" ");
                }

                for (int i = n * 2; i >= 2 * j; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            //=======================================//

            //STRINGS

            //string firstname = "high";
            //string lastname = "higi";

            //Console.WriteLine(firstname.CompareTo(lastname));
            //Console.WriteLine(lastname.CompareTo(firstname));
            //Console.WriteLine(firstname.Contains("jkl"));
            //Console.WriteLine(lastname.EndsWith("b"));
            //Console.WriteLine(lastname.StartsWith("B"));
            //Console.WriteLine(lastname.IndexOf("i"));
            //Console.WriteLine(lastname.LastIndexOf("i"));
            //Console.WriteLine(lastname.ToLower());
            //Console.WriteLine(firstname.ToUpper());
            //Console.WriteLine(lastname.Remove(6));
            //Console.WriteLine(firstname.Replace('q', 'Q'));
            //Console.WriteLine(firstname.Substring(1, 4));
            //Console.WriteLine(firstname.Trim());
            //Console.WriteLine(firstname.GetTypeCode());
            //Console.WriteLine(firstname.Equals(lastname));
            //Console.WriteLine(firstname.Insert(8, " Bin Shoaib Ansari"));

            //==============================================================//

            //PASCAL TRIANGLE WITH JAGGED ARRAY

            //int[][] pascal = new int[5][];

            //for (int i = 0; i < pascal.Length; i++) 
            //{
            //    pascal[i] = new int[i+1];
            //    for (int j = 0; j < pascal[i].Length; j++)
            //    {
            //        if (j == 0 || j == pascal[i].Length-1)
            //        {
            //            pascal[i][j] = 1;
            //        }
            //        else
            //        {
            //            pascal[i][j] = pascal[i - 1][j] + pascal[i - 1][j - 1];
            //        }

            //    }
            //}

            //for (int i = 0; i < pascal.Length; i++)
            //{
            //    for (int j = pascal.Length - 1; j >= i; j--)
            //    {
            //        Console.Write("  ");
            //    } 




            //    for (int j = 0; j < pascal[i].Length; j++)
            //    {
            //        Console.Write(+pascal[i][j]+"   ");
            //    }
            //    Console.WriteLine();
            //}

            //======================================================//


            //DUPLICATE NUMBER IN ARRAY 

            // int[] arr = { 3, 4, 2, 4, 2, 4, 2, 7, 9, 6, 6, 5, 4, 2, 1, 3, 4, 4, 5, 7, 0, 8 };
            // int[] counter = new int[arr.Length];

            //int unique = 0, duplicate = 0;

            // bool flag = true;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     for (int j = 0; j < arr.Length; j++)
            //     {
            //         if (arr[i] == arr[j])
            //         {
            //                 for (int k = 0; k < i; k++)
            //                 {
            //                     if (arr[i] == arr[k])
            //                     {
            //                         flag = false;
            //                     }

            //                 }
            //                 if (flag)
            //                 {
            //                     counter[i]++;
            //                 }
            //                 flag = true;

            //         }
            //     }
            // }

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (counter[i] > 0)
            //     {
            //         unique++;
            //         Console.WriteLine("Frequency of {0} is {1}", arr[i], counter[i]);
            //     }

            //     if (counter[i] > 1)
            //     {
            //         duplicate++;
            //     }
            // }
            // Console.WriteLine("There are {0} unique values and {1} dup;icate values", unique, duplicate);

            //==============================================================================================//

            //RETURN CHANGE

            //Console.Write("Enter a price: ");
            //int price = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a paid: ");
            //int paid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //int returnamount = paid - price;


            //while (returnamount > 0)
            //if (returnamount >= 100)
            //    {
            //        Console.Write(100+" ");
            //        returnamount -= 100;
            //    }

            //else if (returnamount >= 50)
            //    {
            //        Console.Write(50 + " ");
            //        returnamount -= 50;
            //    }

            //else if (returnamount >= 20)
            //{
            //    Console.Write(20 + " ");
            //    returnamount -= 20;
            //}

            //else if (returnamount >= 10)
            //{
            //    Console.Write(10 + " ");
            //    returnamount -= 10;
            //}

            //else if (returnamount >= 5)
            //{
            //    Console.Write(5 + " ");
            //    returnamount -= 5;
            //}

            //else if (returnamount >= 2)
            //{
            //    Console.Write(2 + " ");
            //    returnamount -= 2;
            //}

            //else if (returnamount >= 1)
            //{
            //    Console.Write(1 + " ");
            //    returnamount -= 1;
            //}

            //==================================//

            //PALINDROME

            //string a = "radar";
            //char[] c = new char[a.Length / 2];
            //char[] c1 = new char[a.Length / 2];
            //for (int i = 0; i < c.Length; i++)
            //{
            //    c[i] = a[i];
            //}

            //int count = 0;
            //for (int i = a.Length - 1; i > c.Length; i--)
            //{
            //    c1[count] = a[i];
            //    count++;
            //}

            //string s, s1;
            //s = new string(c);
            //s1 = new string(c1);

            //if (s.CompareTo(s1) == 0)
            //{
            //    Console.WriteLine("Your input is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Your input is not Palindrome");
            //}

            //=======================================================//

            //FOREACH LOOP

            int[] arr = { 1, 2, 3, 4, 5, 6 };

            foreach(int a in arr)
            {
                int b = a * 2;
                Console.WriteLine("{0} x {1} = {2}", a, 2, b);
            }

            string s = "My name is Shariq";

            foreach(char c in s)
            {
                Console.WriteLine(c);
            }


            Console.ReadLine();
        }
    }
}
