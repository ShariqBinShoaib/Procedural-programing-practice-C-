using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace OOP1
//{
    class Earth
    {
        static void Main(string[] args)
        {
            Human person = new Human();

            person.name = "Shariq";
            person.age = 23;
            person.height = 5.5;
            person.eyeColor = "Black";

            person.speak();
            person.eat();
            person.walk();
            person.work();

        }
    }
//}
