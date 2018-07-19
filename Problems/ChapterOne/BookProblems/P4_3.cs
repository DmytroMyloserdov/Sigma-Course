using System;

namespace ChapterOne.BookProblems
{
    public class P4_3
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("Y");
            Double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine(x < 4 ? "1" : "2");
        }
    }
}
