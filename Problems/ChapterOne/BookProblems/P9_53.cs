using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_53
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            for (int i = 2; i < s.Count; i += 3)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
