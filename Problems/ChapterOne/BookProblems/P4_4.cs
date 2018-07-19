using System;

namespace ChapterOne.BookProblems
{
    public class P4_4
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("Y");
            Double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine(y > 3 ? "1" : "2");
        }
    }
}
