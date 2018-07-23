using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_57
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            for (int i = 1; i < s.Count; i += 2)
            {
                if (s[i] == 'и')
                {
                    Console.WriteLine(s[i]);
                }
            }
        }
    }
}
