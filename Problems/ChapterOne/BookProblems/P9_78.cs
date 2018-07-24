using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_78
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            var sReverse = s.Reverse().ToString();

            Console.WriteLine(String.Compare(s, sReverse) == 0);
        }
    }
}
