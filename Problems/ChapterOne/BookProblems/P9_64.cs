using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_64
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            long count = 0;
            for (int i = 0; i < s.Count - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
