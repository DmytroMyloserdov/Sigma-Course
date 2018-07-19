using System;

namespace ChapterOne.BookProblems
{
    public class P5_28
    {
        public static void Resolve()
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("b");
            Int32.TryParse(Console.ReadLine(), out int b);


            Console.WriteLine(Mult(8, 15));
            Console.WriteLine(Mult(a, 20));
            Console.WriteLine(Mult(1, b));
            Console.WriteLine(Mult(a, b));
        }

        private static long Mult(int a, int b)
        {
            long mult = 1;
            for (int i = a; i <= b; i++)
            {
                mult *= i;
            }
            return mult;
        }
    }
}
