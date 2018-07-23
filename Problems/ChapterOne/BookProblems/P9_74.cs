using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_74
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            for (int i = 0; i < s.Count - 5; i += 5)
            {
                if (s[i] == s[i + 1] && s[i] == s[i + 2] && s[i] == s[i + 3] && s[i] == s[i + 4])
                {
                    Console.WriteLine(true);
                    break;
                }
            }
        }
    }
}
