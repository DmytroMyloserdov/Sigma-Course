using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_67
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(s.Select(c => c != "").Count());
        }
    }
}
