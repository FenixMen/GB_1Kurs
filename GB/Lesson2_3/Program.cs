using System;

namespace Lesson2_3
{
    //Определить, является ли введённое пользователем число чётным.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            long Value = long.Parse(Console.ReadLine());
            if (Value == 0) 
            {
                Console.WriteLine($"Вы вели {Value}"); 
            }
            else if (Value % 2 == 0)
                Console.WriteLine("Вы вели четное число");
            else
                Console.WriteLine("Вы вели не четное число");
        }
    }
}
