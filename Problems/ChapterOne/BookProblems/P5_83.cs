using System;

namespace ChapterOne.BookProblems
{
    public class P5_83
    {
        public static void Resolve()
        {
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);

            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);

            long res = a;
            for (int i = 2; i <= n; i++)
            {
                res *= a;
            }

            Console.WriteLine(res);
        }
    }
}
