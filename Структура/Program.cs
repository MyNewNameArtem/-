using System;

namespace Структура
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            byte age = (byte) int.Parse(Console.ReadLine());
            Console.WriteLine("Your Name is {0} and your age is {1}",name,age);            
            Console.WriteLine("Enter your Birthday: ");
            var Birthday = Console.ReadLine();
            Console.WriteLine("Your Birthday is {0}",Birthday);
            Console.WriteLine("Well,your Name is {0} , your age is {1} and your Birthday is {2}",name,age,Birthday);
        }
    }
}




