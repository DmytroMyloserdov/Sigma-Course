using System;

namespace ChapterOne.BookProblems
{
    public class P9_56
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            while (s.IndexOf("нн") != -1)
            {
                Console.WriteLine("нн");
                s.Replace("нн", "");
            }
        }
    }
}
