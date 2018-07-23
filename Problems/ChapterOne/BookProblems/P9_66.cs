using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_66
    {
        public static void Resolve()
        {
            Console.WriteLine(Console.ReadLine().Count(c => c == ' ') + 1);
        }
    }
}
