using System;

namespace ChapterOne.BookProblems
{
    public class P4_90
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            double k;

            if (Math.Sin(x) < 0)
            {
                k = Math.Pow(x, 2);
            }
            else
            {
                k = Math.Abs(x);
            }

            if (k < x)
            {
                Console.WriteLine(Math.Abs(x));
            }
            else
            {
                Console.WriteLine(k * x);
            }
        }
    }
}
