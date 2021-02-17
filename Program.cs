using System;

namespace GB
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2021, 02, 18);

            Console.WriteLine("Как вас зовут?");
                string name = Console.ReadLine();
                    if (name.ToLower() == "андрей кучма")
                        Console.WriteLine($"Здравствуй сансей! Не забудьте, что следующее занятие состоится [{date.ToLongDateString()}].");
                    else
                         Console.WriteLine($"Привет {name}! Сегодня [{DateTime.Now}].");
        }
    }
}
