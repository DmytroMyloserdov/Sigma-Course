using System;
using System.Collections.Generic;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_154
    {
        public static void Resolve()
        {
            SortedSet<char> set = new SortedSet<char>();
            Console.ReadLine().ToList().ForEach(c => set.Add(c));
            Console.WriteLine(set.Count);
        }
    }
}
