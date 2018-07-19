using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P2_16
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine().Split().ToList();
            Console.Write($"Result: {number[1]}{number[0]}{number[2]}");
        }
    }
}
