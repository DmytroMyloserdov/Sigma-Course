using System;

namespace ChapterOne.BookProblems
{
    public class P9_77
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            if (s.IndexOf('а') >= 0)
            {
                Console.WriteLine(s.IndexOf('а'));
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
