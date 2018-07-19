using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P2_19
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine().Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).ToList();
            var mult = 1;
            number.ForEach(c => mult *= c);
            Console.Write($"Result: sum={number.Sum()}, mult={mult}");

        }
    }
}
