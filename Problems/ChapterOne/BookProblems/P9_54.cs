using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_54
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            s.ToList().ForEach(c => { if (c == 'м' || c == 'н') { Console.WriteLine(c); } });
        }
    }
}
