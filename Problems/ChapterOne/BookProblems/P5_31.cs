using System;

namespace ChapterOne.BookProblems
{
    public class P5_31
    {
        public static void Resolve()
        {
            double sum = 0;
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(n + i, 2);
            }

            Console.WriteLine(sum);
        }
    }
}
