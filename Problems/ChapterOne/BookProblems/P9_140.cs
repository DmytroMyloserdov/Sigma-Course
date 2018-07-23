using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_140
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            Console.WriteLine(s.Count(c => c >= '0' && c <= '9'));
        }
    }
}
