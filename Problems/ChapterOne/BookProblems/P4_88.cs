using System;

namespace ChapterOne.BookProblems
{
    public class P4_88
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            if (x > 2)
            {
                Console.WriteLine(2);
            }
            else if (x > 0 && x <= 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(3* x);
            }
        }
    }
}
