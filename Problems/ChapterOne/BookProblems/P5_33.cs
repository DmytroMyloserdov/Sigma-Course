using System;

namespace ChapterOne.BookProblems
{
    public class P5_33
    {
        public static void Resolve()
        {
            double sum = 0;

            for (int i = 2; i <= 10; i++)
            {
                sum += (i / (i + 1));
            }

            Console.WriteLine(sum);
        }
    }
}
