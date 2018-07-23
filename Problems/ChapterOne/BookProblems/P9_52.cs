using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_52
    {
        public static void Resolve()
        {
            Console.WriteLine("Symbol");
            var symbol = Console.ReadLine().ToCharArray();
            Console.WriteLine("Sentense");
            var s = Console.ReadLine();
            s.ToList().ForEach(c => { if (c == symbol[0]) { Console.WriteLine(c); } });
        }
    }
}
