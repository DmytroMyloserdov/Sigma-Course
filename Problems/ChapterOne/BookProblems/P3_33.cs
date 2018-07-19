using System;

namespace ChapterOne.BookProblems
{
    public class P3_33
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("Y");
            Double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine("а) {0}", (x <= -1 && y <= -2));
            Console.WriteLine("б) {0}", (y <= -3 || y >= 1));
            Console.WriteLine("в) {0}", (y >= 1 || (y >= -4 && y <= -3)));
            Console.WriteLine("г) {0}", (x >= -1 && x <= 1.5 && y >= -0.5 && y <= 1.5));
            Console.WriteLine("д) {0}", (x >= 1 && x <= 4 && y >= 2 && y <= 4));
            Console.WriteLine("е) {0}", (y >= 1 && (x >= 2 || x <= -1)));
            Console.WriteLine("ж) {0}", (x <= 3 && x >= 1 && y <= 1 && y >= -3));
            Console.WriteLine("з) {0}", (y >= 1.5 || (y <= 1.5 && y >= -2 && x <= 2.5 && x >= 1)));
        }
    }
}
