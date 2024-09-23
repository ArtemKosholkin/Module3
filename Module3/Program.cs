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
            /*string myName = "Artem";
            byte myAge = 33;
            bool myPet = true;
            float myShoeSize = 42;

            Console.WriteLine("My name is " + myName + ".");
            Console.WriteLine("Do I have a pet? " + myPet + ".");
            Console.WriteLine("My age is " + myAge + ".");
            Console.WriteLine("My shoe size is " + myShoeSize + ".");

            Console.ReadKey();*/

            /*Console.Write("Введите фразу \n");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.ReadKey();*/

            /*int b = 5;
            int k = -2;
            b := b + k;
            Console.WriteLine(b);
            Console.ReadKey();*/

            /*Console.Write("Введите своё имя \n");
            var name = Console.ReadLine();

            Console.Write("Введите свой возраст \n");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

            Console.ReadKey();*/

            Console.Write("Введите свое имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя {0} и возраст {1} \n", name, age);

            Console.Write("Введите вашу дату рождения: ");
            var birthday = Console.ReadLine();

            Console.WriteLine("Ваша дата рождения {0}", birthday);

            Console.ReadKey();
        }
    }
}
