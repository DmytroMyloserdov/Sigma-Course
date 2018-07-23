using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_142
    {
        public static void Resolve()
        {
            var s = Console.ReadLine().Replace(" ", "");
            var numbers = s.Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).Where(c => c >= '0' && c <= '9').ToList();
            var max = numbers.Max();
            Console.WriteLine("(indexed from 0) Result: {0}", s.IndexOf(max.ToString()));
        }
    }
}
