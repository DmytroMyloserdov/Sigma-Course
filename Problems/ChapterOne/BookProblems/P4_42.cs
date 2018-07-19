using System;

namespace ChapterOne.BookProblems
{
    public class P4_42
    {
        public static void Resolve()
        {
            Console.WriteLine("a");
            Double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("b");
            Double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("c");
            Double.TryParse(Console.ReadLine(), out double c);
            Console.WriteLine(a < b && b < c);
            Console.WriteLine(b > a && a > c);
        }
    }
}
