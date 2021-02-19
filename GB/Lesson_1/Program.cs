using System;

namespace urok
{
    class Program
    {
        static void TextWrite(int lenght, int widht, string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(new String(' ', lenght) + text.PadRight((widht - lenght), ' '));
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void SimvolWrite(string simvol, int widht)
        {
            //                    int position = i;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            for (int i = 0; i < widht; i++)
            {
                Console.Write(simvol);
            }
            Console.Write("|");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму в рублях");
            string countRUB = Console.ReadLine();
            int widht = 50;
            int heightTicket = 26;
            char line = '_';
            for (int i = 0; i <= heightTicket; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                    for (; i < widht; i++)
                    {
                        Console.Write(line);
                    }
                    i = 0;
                    Console.WriteLine();
                }
                if (i == 21)
                {
                    SimvolWrite("* ", widht / 2);
                    i++;
                }
                if (i == 22)
                {
                    SimvolWrite("* ", widht / 2);
                    i++;
                }
                if (i == 24)
                {
                    SimvolWrite(" /", widht / 2);
                    i++;
                }
                if (i == 25)
                {
                    SimvolWrite("/ ", widht / 2);
                    i++;
                }
                if (i == heightTicket)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("|");
                    for (i = 0; i < widht; i++)
                    {
                        Console.Write(line);
                    }
                    Console.Write("|");
                    i = heightTicket;
                    Console.WriteLine();
                }
                if (i < heightTicket)
                {
                    Console.Write("|");
                    if (i == 2)
                        TextWrite(18, widht, "МУП ТП ТРАМВАЙ");
                    else if (i == 5)
                        TextWrite(18, widht, "ПРОЕЗДНОЙ БИЛЕТ");
                    else if (i == 6)
                        TextWrite(21, widht, "№ 17387");
                    else if (i == 9)
                        TextWrite((20 - (countRUB.Length / 2)), widht, ("Сумма " + countRUB + " Руб"));
                    else if (i == 12)
                        TextWrite(8, widht, "Стоимость одной поездки 15 рублей");
                    else if (i == 14)
                        TextWrite(1, widht, new String('=', 48));
                    else if (i == 17)
                        TextWrite(15, widht, ("Осталось " + (int.Parse(countRUB) / 15) + " поездок"));
                    else if (i == 19)
                        TextWrite(19, widht, DateTime.Now.ToShortDateString().ToString());
                    else if (i == 20)
                        TextWrite(1, widht, new String('=', 48));
                    else if (i == 23)
                        TextWrite(1, widht, new String('=', 48));
                    else
                        Console.Write("".PadRight(widht, ' '));
                    Console.WriteLine("|");
                }


            }
            Console.ResetColor();
            Console.ReadLine();

        }

        private static void TextWrite(int v, int widht, object p)
        {
            throw new NotImplementedException();
        }
    }
}
