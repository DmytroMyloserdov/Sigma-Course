using System;
using System.Collections.Generic;

namespace ChapterOne.BookProblems
{
    public class P4_106
    {
        struct Time
        {
            public List<int> monthArray;
            public string TimeOfYear;

            public Time(string time, params int[] month)
            {
                TimeOfYear = time;
                monthArray = new List<int>();
                monthArray.AddRange(month);
            }
        }

        public static void Resolve()
        {
            List<Time> timesOfYear = new List<Time>()
            {
                new Time("Winter", 1, 2, 12),
                new Time("spring", 3, 4, 5),
                new Time("Summer", 6, 7, 8),
                new Time("Fall", 9, 10, 11)
            };
            Console.WriteLine("index");
            Int32.TryParse(Console.ReadLine(), out int i);

            foreach(var timeOfYear in timesOfYear)
            {
                if (timeOfYear.monthArray.Contains(i))
                {
                    Console.WriteLine(timeOfYear.TimeOfYear);
                    return;
                }
            }
        }
    }
}
