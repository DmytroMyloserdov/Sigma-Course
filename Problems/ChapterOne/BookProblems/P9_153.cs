using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_153
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            long curCount = 0, maxCount = 0;
            for (int i = 1; i < s.Count; i++)
            {
                if (s[i] == s[i - 1])
                {
                    curCount++;
                }
                else
                {
                    maxCount = maxCount >= curCount ? maxCount : curCount;
                    curCount = 0;
                }
            }
        }
    }
}
