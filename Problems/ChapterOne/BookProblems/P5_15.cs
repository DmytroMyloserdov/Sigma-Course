using System;

namespace ChapterOne.BookProblems
{
    public class P5_15
    {
        public static void Resolve()
        {
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}*{n}={i * n}");
            }
        }
    }
}
