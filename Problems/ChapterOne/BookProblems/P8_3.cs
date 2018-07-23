using System;

namespace ChapterOne.BookProblems
{
    public class P8_3
    {
        public static void Resolve()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
            }

            int k = 5;
            for (int i = 5; i >= 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(k + " ");
                }
                Console.Write("\n");
                k--;
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i * 10 + " ");
                }
                Console.Write("\n");
            }

            k = 1;
            for (int i = 5; i >= 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(5 * k + " ");
                }
                Console.Write("\n");
                k++;
            }
        }
    }
}
