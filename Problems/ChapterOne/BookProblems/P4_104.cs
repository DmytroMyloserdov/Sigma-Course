using System;
using System.Collections.Generic;

namespace ChapterOne.BookProblems
{
    public class P4_104
    {
        public static void Resolve()
        {
            List<string> days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sanday" };
            Console.WriteLine("index");
            Int32.TryParse(Console.ReadLine(), out int i);
            Console.WriteLine(days[i - 1]);
        }
    }
}
