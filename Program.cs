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
            const string myName = "Artem";
            
            Console.WriteLine(myName);
            Console.WriteLine("\t Привет, Мир!");
            Console.WriteLine("\t Меня зовут \n Артем");
            Console.WriteLine('\u0023'); //вывод символа # согласно ASCII
            Console.WriteLine('\x23'); //можно и так, только непонятно, почему?

            Console.WriteLine("\n Для продолжения нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
