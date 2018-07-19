using System;

namespace ChapterOne.BookProblems
{
    public class P5_37
    {
        public static void Resolve()
        {
            double sum = 1;
            Console.WriteLine("x");
            Int32.TryParse(Console.ReadLine(), out int x);

            for (int i = 1; i <= 10; i++)
            {
                sum += (Math.Pow(-1, i) * ((i + 1) / (i + 2)) * Math.Pow(x, i));
            }

            Console.WriteLine(sum);
        }
    }
}
