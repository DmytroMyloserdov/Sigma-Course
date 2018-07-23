using System;

namespace ChapterOne.BookProblems
{
    public class P8_36
    {
        public static void Resolve()
        {
            for (int k = 6; k <= 100000; k++)
            {
                for (int i = 1; i <= k / 2; i++)
                {
                    if (k % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
