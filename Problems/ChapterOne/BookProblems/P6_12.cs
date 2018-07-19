using System;

namespace ChapterOne.BookProblems
{
    public class P6_12
    {
        public static void Resolve()
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);

            int i;
            for (i = 2; (1 + 1 / i) >= a; i++) { }

            Console.WriteLine((1 + 1 / (double)i));
        }
    }
}
