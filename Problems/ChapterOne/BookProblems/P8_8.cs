using System;

namespace ChapterOne.BookProblems
{
    public class P8_8
    {
        public static void Resolve()
        {
            int i, j;

            for (i = 1; i <= 9; i++)
            {
                for (int q = 1; q <= 9; q++)
                {
                    Console.Write($"{q} x {i} = {q * i}{addStr(q * i)}");
                }
                Console.WriteLine();
            }
        }

        private static string addStr(int dig)
        {
            if (dig > 9)
            {
                return "   ";
            }
            else
            {
                return "    ";
            }
        }
    }
}
