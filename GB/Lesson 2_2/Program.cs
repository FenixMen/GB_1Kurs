using System;

namespace Lesson2_2
{
    //Запросить у пользователя порядковый номер текущего месяца и вывести его название.

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
            October
        }

        static void Main(string[] args)
        {



            Console.WriteLine("Введите порядковый номер текущего месяца");
            int isMounth = int.Parse(Console.ReadLine());

            switch (isMounth)
            {
                case 1:
                    Console.WriteLine($"Switch:\tТекущий месяц Январь");
                    break;
                case 2:
                    Console.WriteLine($"Switch:\tТекущий месяц Февраль");
                    break;
                case 3:
                    Console.WriteLine($"Switch:\tТекущий месяц Март");
                    break;
                case 4:
                    Console.WriteLine($"Switch:\tТекущий месяц Апрель");
                    break;
                case 5:
                    Console.WriteLine($"Switch:\tТекущий месяц Май");
                    break;
                case 6:
                    Console.WriteLine($"Switch:\tТекущий месяц Июнь");
                    break;
                case 7:
                    Console.WriteLine($"Switch:\tТекущий месяц Июль");
                    break;
                case 8:
                    Console.WriteLine($"Switch:\tТекущий месяц Август");
                    break;
                case 9:
                    Console.WriteLine($"Switch:\tТекущий месяц Сентябрь");
                    break;
                case 10:
                    Console.WriteLine($"Switch:\tТекущий месяц Октябрь");
                    break;
                case 11:
                    Console.WriteLine($"Switch:\tТекущий месяц Ноябрь");
                    break;
                case 12:
                    Console.WriteLine($"Switch:\tТекущий месяц Декабрь");
                    break;
            }
            Console.WriteLine($"Enum:\tТекущий месяц {(Mounth)isMounth}");
        }
    }
}
