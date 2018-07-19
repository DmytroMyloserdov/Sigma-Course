using System;

namespace ChapterOne.BookProblems
{
    public class P4_87
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            if (x <= 0)
            {
                Console.WriteLine(0);
            }
            else if (x > 0 && x <= 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(Math.Pow(x, 2));
            }
        }
    }
}
