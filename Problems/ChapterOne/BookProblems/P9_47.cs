using System;

namespace ChapterOne.BookProblems
{
    public class P9_47
    {
        public static void Resolve()
        {
            Console.WriteLine("Symbol");
            var s = Console.ReadLine();
            Console.WriteLine("Count");
            Int32.TryParse(Console.ReadLine(), out int count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(s);
            }
        }
    }
}
