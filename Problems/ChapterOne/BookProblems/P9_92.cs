using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_92
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            for (int i = 1; i < s.Count; i += 2)
            {
                s[i] = 'ы';
            }
            s.ForEach(c => Console.Write(c));
        }
    }
}
