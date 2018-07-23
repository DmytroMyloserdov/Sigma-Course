using System;

namespace ChapterOne.BookProblems
{
    public class P9_75
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            if (s.IndexOf(',') >= 0)
            {
                Console.WriteLine(s.Substring(0, s.IndexOf(',')));
            }
            else
            {
                Console.WriteLine(s);
            }
        }
    }
}
