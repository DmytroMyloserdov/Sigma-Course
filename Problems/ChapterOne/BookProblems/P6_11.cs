using System;

namespace ChapterOne.BookProblems
{
    public class P6_11
    {
        public static void Resolve()
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);

            for (int i = 2; (1 + 1 / i) >= a; i++)
            {
                Console.Write((1 + 1 / (double)i) + " ");
            }
        }
    }
}
