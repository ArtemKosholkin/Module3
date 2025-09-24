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
            //const string myName = "Artem";
            //Console.WriteLine(myName);
            //Console.WriteLine("\t Привет, Мир!");
            //Console.WriteLine("\t Меня зовут \n Артем");
            //Console.WriteLine('\u0023'); //вывод символа # согласно ASCII
            //Console.WriteLine('\x23'); //можно и так, только непонятно, почему?

            //Console.WriteLine("IntMinValue = {0}", int.MinValue);
            //Console.WriteLine("ByteMaxValue = {0}", byte.MaxValue);

            //string myName = "Artem";
            //byte myAge = 35;
            //bool myPet = true;
            //double myShoeSize = 42.5;
            //Console.WriteLine("My name is " + myName);
            //Console.WriteLine("My age is " + myAge);
            //Console.WriteLine("Do I have a pet? " + myPet);
            //Console.WriteLine("My shoe size is " + myShoeSize);

            //Урок 3.5.

            //string MyName = "Артем";
            //byte MyAge = 35;
            //Console.WriteLine("Привет, Мир!");
            //Console.WriteLine();
            //Console.WriteLine($"Меня зовут {MyName}");
            //Console.WriteLine($"Мой возраст {MyAge}");

            //Задание 3.5.5
            //Console.Write("Напишите что-нибудь: ");
            //string str = Console.ReadLine();
            //Console.WriteLine("Вы написали: {0}", str);

            //Урок 3.6

            //double result = 5.0 / 2.0;
            //Console.WriteLine("5/2 = {0}", result);

            //int counter = 10;
            //Console.WriteLine("Value: {0} ++Increment: {1}", counter, ++counter);
            //Console.WriteLine("Value: {0} Increment++: {1}", counter, counter++);

            double result = 10 % 3;
            Console.WriteLine(result);

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую кнопку");
            Console.ReadKey();
        }
    }
    //Урок 3.4 задание 3.4.3
    //enum Semaphore : int
    //{
    //    Red = 100,
    //    Yellow = 200,
    //    Green = 300
    //}
}
