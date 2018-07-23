using System;

namespace ChapterOne.BookProblems
{
    public class P9_73
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.LastIndexOf('с') > s.LastIndexOf('т') ? 'с' : 'т');
        }
    }
}
