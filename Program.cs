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
            /*
            const string myName = "Artem";
            
            Console.WriteLine(myName);
            Console.WriteLine("\t Привет, Мир!");
            Console.WriteLine("\t Меня зовут \n Артем");
            Console.WriteLine('\u0023'); //вывод символа # согласно ASCII
            Console.WriteLine('\x23'); //можно и так, только непонятно, почему?
            */
            string myName = "Artem";
            byte myAge = 35;
            bool myPet = true;
            double myShoeSize = 42.5;

            Console.WriteLine("My name is " + myName);
            Console.WriteLine("My age is " + myAge);
            Console.WriteLine("Do I have a pet? " + myPet);
            Console.WriteLine("My shoe size is " + myShoeSize);

            Console.WriteLine("\n Для продолжения нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
