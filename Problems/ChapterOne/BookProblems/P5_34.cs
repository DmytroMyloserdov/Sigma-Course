using System;

namespace ChapterOne.BookProblems
{
    public class P5_34
    {
        public static void Resolve()
        {
            double prev = 1, sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                sum += (1 / prev);
                prev /= 3;
            }

            Console.WriteLine(sum);
        }
    }
}
