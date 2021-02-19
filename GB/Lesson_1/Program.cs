using System;

namespace GB
{   //Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, 
    //к примеру, чтобы описать работу какого либо офиса. Явный пример - офис номер 1 работает со вторника до пятницы, 
    //офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.
    class Program
    {
        enum DayOfWeek
        {
            Monday = 0b_1000000,
            Tuesday = 0b_0100000,
            Wednesday = 0b_0010000,
            Thursday = 0b_0001000,
            Friday = 0b_0000100,
            Saturday = 0b_0000010,
            Sunday = 0b_0000001,
        }

    static void Main(string[] args)
        {
            byte officeOne = 0b_01111_00;
            int officeTwo = 0b_11111_11;

                foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                {
                    if((officeOne & (byte)day) == (byte)day)
                {
                    Console.WriteLine((DayOfWeek)day);
                }
                }
                



        }
    }
}
