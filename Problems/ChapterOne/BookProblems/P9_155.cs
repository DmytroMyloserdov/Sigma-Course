using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_155
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            s.ForEach(c =>
            {
                if (s.Count(x => x == c) == 2)
                {
                    Console.WriteLine(c);
                    return;
                }
            });
        }
    }
}
