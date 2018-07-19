using System;

namespace ChapterOne.BookProblems
{
    public class P6_33
    {
        public static void Resolve()
        {
            int count = 100 / 13;
            for (int i = 1; i <= count; i++)
            {
                Console.Write(i * 13 + " ");
            }
        }
    }
}
