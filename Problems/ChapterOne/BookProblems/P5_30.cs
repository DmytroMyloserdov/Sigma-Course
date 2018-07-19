using System;

namespace ChapterOne.BookProblems
{
    public class P5_30
    {
        public static void Resolve()
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("b");
            Int32.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);


            Console.WriteLine(Sum3(20, 40));
            Console.WriteLine(Sum3(a, 50));
            Console.WriteLine(Sum3(1, n));
            Console.WriteLine(Sum3(a, b));
        }

        private static double Sum3(int a, int b)
        {
            double sum = 0.0;
            for (int i = a; i <= b; i++)
            {
                sum += Math.Pow(i, 3);
            }
            return sum;
        }
    }
}
