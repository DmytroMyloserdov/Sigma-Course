using System;

namespace ChapterOne.BookProblems
{
    public class P5_27
    {
        public static void Resolve()
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("b");
            Int32.TryParse(Console.ReadLine(), out int b);


            Console.WriteLine(Sum(100, 500));
            Console.WriteLine(Sum(a, 500));
            Console.WriteLine(Sum(-10, b));
            Console.WriteLine(Sum(a, b));
        }

        private static long Sum(int a, int b)
        {
            long sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
