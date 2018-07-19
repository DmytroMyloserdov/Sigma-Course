using System;

namespace ChapterOne.BookProblems
{
    public class P4_37
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine((x > -5 && x < 3));
        }
    }
}
