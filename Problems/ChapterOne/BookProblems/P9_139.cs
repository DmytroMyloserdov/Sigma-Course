using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_139
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            s.ForEach(c =>
            {
                if (c >= '0' && c <= '9')
                {
                    Console.WriteLine(c);
                }
            });
        }
    }
}
