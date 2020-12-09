using System;

namespace Lesson1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите пожалуйста свое имя.");
            String name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now.ToLongDateString()}");
            Console.ReadLine();
        }
    }
}
