using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_58
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            for (int i = 0; i < s.Count - 1; i += 4)
            {
                Console.WriteLine(s[i] + "\n" + s[i + 1]);
            }
        }
    }
}
