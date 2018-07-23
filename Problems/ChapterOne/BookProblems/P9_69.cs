using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_69
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Count(c => c == '.'));
        }
    }
}
