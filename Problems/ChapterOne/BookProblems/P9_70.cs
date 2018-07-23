using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_70
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            var letters = "уеаоэяиюёы";
            Console.WriteLine(s.Count(c => letters.IndexOf(c) != -1));
        }
    }
}
