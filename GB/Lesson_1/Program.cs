using System;

namespace GB
{   //Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, 
    //к примеру, чтобы описать работу какого либо офиса. Явный пример - офис номер 1 работает со вторника до пятницы, 
    //офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.
    class Program
    {
        enum DayOfWeek
        {
            Monday = 0b_00_00001,
            Tuesday = 0b_00_00010,
            Wednesday = 0b_00_00100,
            Thursday = 0b_00_01000,
            Friday = 0b_00_10000,
            Saturday = 0b_01_00000,
            Sunday = 0b_10_00000,
        }

    static void Main(string[] args)
        {
            byte officeOne = 0b_01111_00;
            int officeTwo = 0b_11111_11;


            Console.Write($"Офис 1 работает - :") ;
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                if ((officeOne & (byte)day) == (byte)day)
                    Console.Write($" {(DayOfWeek)day} :");
            }

            Console.Write($"\nОфис 2 работает - :");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                if ((officeTwo & (byte)day) == (byte)day)
                    Console.Write($" {(DayOfWeek)day} :");
            }




        }
    }
}
