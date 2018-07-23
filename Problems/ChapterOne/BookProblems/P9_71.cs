using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_71
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Count(c => c == 'м') > s.Count(c => c == 'н') ? 'м' : 'н');
        }
    }
}
