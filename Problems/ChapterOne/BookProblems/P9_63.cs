using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_63
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            Console.WriteLine(s.Count(c => c == '+') + "+\n" + s.Count(c => c == '*') + "*");
        }
    }
}
