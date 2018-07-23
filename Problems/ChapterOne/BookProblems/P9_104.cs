using System;
using System.Collections.Generic;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_104
    {
        static List<char> s;

        public static void Resolve()
        {
            s = Console.ReadLine().ToList();
            var count = s.Count - 1;
            for (int i = 0; i < s.Count / 2; i++)
            {
                Swap(i, count - i);
            }
            s.ForEach(c => Console.Write(c));
        }

        private static void Swap(int m, int n)
        {
            var tempM = (int)s[m - 1];
            var tempN = (int)s[n - 1];

            s[m - 1] = (char)tempN;
            s[n - 1] = (char)tempM;
        }
    }
}
