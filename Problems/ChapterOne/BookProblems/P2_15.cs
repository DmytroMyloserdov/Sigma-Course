using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P2_15
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine().Split().ToList();
            Console.Write($"Result: {number[2]}{number[0]}{number[1]}");
        }
    }
}
