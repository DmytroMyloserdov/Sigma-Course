using System;

namespace ChapterOne.BookProblems
{
    public class P1_24
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter a:");
            Double.TryParse(Console.ReadLine(), out double a);
            double x = Math.Sqrt((2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56);
            double res = Math.Sin((3.2 + Math.Sqrt(1 + x)) / Math.Abs(5 * x));
            Console.WriteLine($"Result: {res}");
        }
    }
}
