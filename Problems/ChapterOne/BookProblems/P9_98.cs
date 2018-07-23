using System;

namespace ChapterOne.BookProblems
{
    public class P9_98
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter sentence");
            var s = Console.ReadLine();
            Console.WriteLine("Enter s1");
            var s1 = Console.ReadLine();
            Console.WriteLine("Enter s2");
            var s2 = Console.ReadLine();

            Console.WriteLine(s.Replace(s1, s2));
        }
    }
}
