using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_143
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().ToList();
            if (s.Count(c => c < '0' || c > '9') > 0 || s[0] == '0')
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
