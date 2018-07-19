using System;

namespace ChapterOne.BookProblems
{
    public class P4_92
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            if (x < 1) { Console.WriteLine(1); }
            else if (x > 5) { Console.WriteLine(3); }
            else { Console.WriteLine(2); }
        }
    }
}
