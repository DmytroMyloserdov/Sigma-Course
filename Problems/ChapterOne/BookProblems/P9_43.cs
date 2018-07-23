using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_43
    {
        public static void Resolve()
        {
            var s1 = Console.ReadLine().ToList();
            for (int i = 1; i < s1.Count; i += 2)
            {
                Console.Write(s1[i]);
            }
        }
    }
}
