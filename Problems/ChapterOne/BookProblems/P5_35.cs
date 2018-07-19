using System;

namespace ChapterOne.BookProblems
{
    public class P5_35
    {
        public static void Resolve()
        {
            double sum = 0;
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);

            for (int i = 1; i <= n; i += 2)
            {
                sum += (1 / i);
            }

            for (int i = 2; i <= n; i += 2)
            {
                sum += (1 / i);
            }

            Console.WriteLine(sum);
        }
    }
}
