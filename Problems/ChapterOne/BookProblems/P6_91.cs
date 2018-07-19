using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P6_91
    {
        public static void Resolve()
        {
            Console.WriteLine("N");
            var number = Console.ReadLine().Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).ToList();
            Console.WriteLine(number.Count);
            Console.WriteLine(number.Sum());
            long mult = 1;
            number.ForEach(c => mult *= c);
            Console.WriteLine(mult);
            Console.WriteLine(number.Sum() / (double)number.Count());
            mult = 0;
            number.ForEach(c => mult += c * c);
            Console.WriteLine(mult);
        }
    }
}
