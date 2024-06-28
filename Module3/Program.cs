using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Artem";
            byte myAge = 33;
            bool myPet = true;
            float myShoeSize = 42;

            Console.WriteLine("My name is " + myName + ".");
            Console.WriteLine("Do I have a pet? " + myPet + ".");
            Console.WriteLine("My age is " + myAge + ".");
            Console.WriteLine("My shoe size is " + myShoeSize + ".");


            Console.ReadKey();
        }
    }
}
