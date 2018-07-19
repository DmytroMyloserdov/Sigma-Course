using System;

namespace ChapterOne.BookProblems
{
    public class P4_40
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine((x >= -2.4 && x <= 5.7) ? Math.Pow(x, 2) : 4);
        }
    }
}
