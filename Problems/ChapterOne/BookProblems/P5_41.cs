using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P5_41
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter 12 numbers separating by whitespace");

            Console.WriteLine(Console.ReadLine().Split(' ').Select(c => { Double.TryParse(c, out double a); return a; }).ToList().Sum());
        }
    }
}
