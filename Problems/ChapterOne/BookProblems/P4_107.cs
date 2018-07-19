using System;
using System.Collections.Generic;

namespace ChapterOne.BookProblems
{
    public class P4_107
    {
        struct DayAmount
        {
            public List<int> monthArray;
            public int Value;

            public DayAmount(int value, params int[] month)
            {
                Value = value;
                monthArray = new List<int>();
                monthArray.AddRange(month);
            }
        }

        public static void Resolve()
        {
            List<DayAmount> dayAmount = new List<DayAmount>()
            {
                new DayAmount(31, 1, 3, 5, 7, 8, 10, 12),
                new DayAmount(30, 4, 6, 9, 11)
            };

            Console.WriteLine("index");
            Int32.TryParse(Console.ReadLine(), out int i);
            Console.WriteLine("Visokos?(y/n)");
            bool visokos = Console.ReadLine().Contains("y");

            if (i == 2) { Console.WriteLine(28); }
            if (visokos && i == 2) { Console.WriteLine(29); return; }

            foreach(var day in dayAmount)
            {
                if (day.monthArray.Contains(i))
                {
                    Console.WriteLine(day.Value);
                    return;
                }
            }
        }
    }
}
