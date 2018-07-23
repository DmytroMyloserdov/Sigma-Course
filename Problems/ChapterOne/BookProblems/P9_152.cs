using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_152
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            long curCount = 0, maxCount = 0;
            s.ForEach(c =>
            {
                if (c == ' ')
                {
                    curCount++;
                }
                else
                {
                    maxCount = maxCount >= curCount ? maxCount : curCount;
                    curCount = 0;
                }
            });

            Console.WriteLine(maxCount);
        }
    }
}
