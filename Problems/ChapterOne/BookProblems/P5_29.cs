using System;

namespace ChapterOne.BookProblems
{
    public class P5_29
    {
        public static void Resolve()
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("b");
            Int32.TryParse(Console.ReadLine(), out int b);


            Console.WriteLine(Average(1, 1000));
            Console.WriteLine(Average(100, b));
            Console.WriteLine(Average(a, 200));
            Console.WriteLine(Average(a, b));
        }

        private static double Average(int a, int b)
        {
            double sum = 0.0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum / (b - a + 1);
        }
    }
}
