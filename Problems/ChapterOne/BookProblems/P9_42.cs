using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_42
    {
        public static void Resolve()
        {
            Console.ReadLine().Reverse().ToList().ForEach(c => Console.Write(c));
        }
    }
}
