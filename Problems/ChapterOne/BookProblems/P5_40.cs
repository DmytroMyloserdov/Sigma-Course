using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P5_40
    {
        public static void Resolve()
        {
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);

            Console.WriteLine("Enter n numbers separating by whitespace");

            Console.WriteLine(Console.ReadLine().Split(' ').Select(c => { Double.TryParse(c, out double a); return a; }).ToList().Sum());
        }
    }
}
