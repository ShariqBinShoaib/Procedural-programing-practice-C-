using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace OOP1
//{
    class Human
    {
        public string name;
        public int age;
        public double height;
        public string eyeColor;

        public void speak()
        {
            Console.WriteLine("Hello! My name is " + name);
            Console.WriteLine("I'm "+age+" years old");
            Console.WriteLine("I'm " + height + " feet tall");
            Console.WriteLine("My Eye color is " + eyeColor);

        }

        public void eat()
        {
            Console.WriteLine("Eating...");

        }

        public void walk()
        {
            Console.WriteLine("Walking...");
        }

        public void work()
        {
            Console.WriteLine("Walking...");
        }
    }
//}
