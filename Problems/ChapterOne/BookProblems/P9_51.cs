using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_51
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            s.ToList().ForEach(c => { if (c == 'и') { Console.WriteLine(c); } });
        }
    }
}
