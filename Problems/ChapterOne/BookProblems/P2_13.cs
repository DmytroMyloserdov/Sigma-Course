using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P2_13
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine().Reverse();
            Console.WriteLine($"result: {number}");
        }
    }
}
