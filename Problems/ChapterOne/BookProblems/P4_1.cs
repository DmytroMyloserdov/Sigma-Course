using System;

namespace ChapterOne.BookProblems
{
    public class P4_1
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("Y={0}", x > 0 ? Math.Pow(Math.Sin(x), 2) : (1 - 2 * Math.Sin(Math.Pow(x, 2))));
        }
    }
}
