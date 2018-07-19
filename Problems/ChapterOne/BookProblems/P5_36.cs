using System;

namespace ChapterOne.BookProblems
{
    public class P5_36
    {
        public static void Resolve()
        {
            double sum = 0;
            Console.WriteLine("x");
            Int32.TryParse(Console.ReadLine(), out int x);

            for (int i = 1; i <= 11; i++)
            {
                sum += (Math.Pow(x, i) / i);
            }

            Console.WriteLine(sum);
        }
    }
}
