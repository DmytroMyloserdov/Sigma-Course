using System;
using System.Linq;

namespace ChapterOne.ArrayProblems
{
    public class P4_6
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var res = Console.ReadLine().Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList().Max();
            Console.WriteLine($"Result: {res}");
        }
    }
}
