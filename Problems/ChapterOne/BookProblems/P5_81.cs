using System;

namespace ChapterOne.BookProblems
{
    public class P5_81
    {
        public static void Resolve()
        {
            Console.WriteLine("x");
            Int32.TryParse(Console.ReadLine(), out int x);

            Console.WriteLine("y");
            Int32.TryParse(Console.ReadLine(), out int y);

            long sum = 0;
            for (int i = 0; i < y; i++)
            {
                sum += x;
            }
            Console.WriteLine(sum);
            sum = 0;
            for (int i = 0; i < x; i++)
            {
                sum += y;
            }
            Console.WriteLine(sum);
        }
    }
}
