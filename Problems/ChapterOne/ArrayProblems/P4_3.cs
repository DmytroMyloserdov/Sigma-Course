using System;
using System.Linq;

namespace ChapterOne.ArrayProblems
{
    public class P4_3
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var arr = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToList();
            int res = 0;
            arr.ForEach(c => res += c < 0 ? c : 0);
            Console.WriteLine($"Result: {res}");
        }
    }
}
