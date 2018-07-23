using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_61
    {
        public static void Resolve()
        {
            Console.WriteLine("Symbol");
            var symbol = Console.ReadLine().ToCharArray();
            Console.WriteLine(Console.ReadLine().Count(c => c == symbol[0]));
        }
    }
}
