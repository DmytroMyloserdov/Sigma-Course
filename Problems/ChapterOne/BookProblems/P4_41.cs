using System;

namespace ChapterOne.BookProblems
{
    public class P4_41
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine((x >= 0.2 && x <= 0.9) ? Math.Sin(x) : 1);
        }
    }
}
