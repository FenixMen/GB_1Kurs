using System;

namespace Lesson2_1
{
    // Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
    //(*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
    class Program
    {
        enum Mounth
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление среднесуточной температуры за сутки");
            Console.WriteLine("Введите минимальное значение температуры");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение температуры");
            int maxValue = int.Parse(Console.ReadLine());
            int mediumValue = (minValue + maxValue) / 2;
        Console.WriteLine("Введите номер текущего месяца");
            int isMounth = int.Parse(Console.ReadLine());
            if ((isMounth == 12 || isMounth == 1 || isMounth == 2) && mediumValue > 0)
                Console.WriteLine($"Среднесуточная температура = {mediumValue}°, текущий месяц - {(Mounth)isMounth}\n Выдалась дожливая зима!");
            else
            Console.WriteLine($"Среднесуточная температура = {mediumValue}°, текущий месяц - {(Mounth)isMounth}.");

        }
    }
}

