using System;

namespace ChapterOne.BookProblems
{
    public class P4_38
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("Y");
            Double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine("a) " + (x > 3 && y > 2));
            Console.WriteLine("b) " + (x < -2 && y < 4));
        }
    }
}
