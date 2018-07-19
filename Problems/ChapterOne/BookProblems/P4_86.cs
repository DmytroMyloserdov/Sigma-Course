using System;

namespace ChapterOne.BookProblems
{
    public class P4_86
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            if (x < 0)
            {
                Console.WriteLine(1);
            }
            else if (x > 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
