using System;

namespace ChapterOne.BookProblems
{
    public class P4_5
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("a) {0}", x < 2 ? x : 2);
            Console.WriteLine("б) {0}", x < 3 ? -x : -3);
        }
    }
}
