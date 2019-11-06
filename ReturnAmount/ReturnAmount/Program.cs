using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            int price, paid, retorn;
            Console.Write("Enter a price: ");
            price = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter a paid: ");
            paid = Convert.ToInt32(Console.ReadLine());

            retorn = paid - price;



        }
    }
}
