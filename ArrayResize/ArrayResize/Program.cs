using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResize
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 6 , sum = 0;
            string[] temp = new string[size];
            Console.WriteLine("Enter the runs on the ball: ");
            for (int i = 0; i < size; i++)
            {
                temp[i] = Console.ReadLine();
                if (temp[i] == "N" || temp[i] == "n")
                {
                    Array.Resize<string>(ref temp, ++size);
                    sum += 1;
                }
                else
                {
                    sum += Convert.ToInt32(temp[i]);
                }

            }

            Console.WriteLine("\n"+sum);

            Console.ReadLine();
        }
    }
}
