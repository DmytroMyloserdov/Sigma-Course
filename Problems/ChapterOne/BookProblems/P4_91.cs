using System;

namespace ChapterOne.BookProblems
{
    public class P4_91
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);

            if (x < -1) { Console.WriteLine(0); }
            else if (x > 1) { Console.WriteLine(1); }
            else { Console.WriteLine(x); }

            if (x < -1) { Console.WriteLine(1); }
            else if (x > 1) { Console.WriteLine(-1); }
            else { Console.WriteLine(-x); }

            if (x < -1) { Console.WriteLine(1); }
            else if (x > 1) { Console.WriteLine(1); }
            else if (x >= -1 && x <= 0) { Console.WriteLine(-0.5 * x + 0.5); }
            else { Console.WriteLine(0.5 * x + 0.5); }
        }
    }
}
