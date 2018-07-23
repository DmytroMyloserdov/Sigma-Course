using System;

namespace ChapterOne.BookProblems
{
    public class P9_50
    {
        public static void Resolve()
        {
            Console.WriteLine("First");
            var first = Console.ReadLine();
            Console.WriteLine("Second");
            var second = Console.ReadLine();
            Console.WriteLine("Count");
            Int32.TryParse(Console.ReadLine(), out int count);

            Console.WriteLine(first + second.Remove(0, count));
        }
    }
}
