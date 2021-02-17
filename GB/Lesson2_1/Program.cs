using System;

namespace Lesson2_1
{
   // Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление среднесуточной температуры за сутки");
            Console.WriteLine("Введите минимальное значение температуры");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение температуры");
            int maxValue = int.Parse(Console.ReadLine());

            Console.WriteLine($"Среднесуточная температура = {(minValue + maxValue) / 2}°");

        }
    }
}
