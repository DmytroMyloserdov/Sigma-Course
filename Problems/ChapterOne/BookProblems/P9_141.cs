using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_141
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).Where(c => c >= '0' && c <= '9').ToList();
            Console.WriteLine(s.Sum());
            Console.WriteLine(s.Max());
        }
    }
}
