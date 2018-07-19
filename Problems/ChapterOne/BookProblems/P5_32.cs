using System;

namespace ChapterOne.BookProblems
{
    public class P5_32
    {
        public static void Resolve()
        {
            double sum = 0;
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);

            for (int i = 1; i <= n; i++)
            {
                sum += (1 / i);
            }

            Console.WriteLine(sum);
        }
    }
}
