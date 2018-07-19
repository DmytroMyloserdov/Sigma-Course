using System;

namespace ChapterOne.BookProblems
{
    public class P4_68
    {
        public static void Resolve()
        {
            Console.WriteLine("a");
            Double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("v0");
            Double.TryParse(Console.ReadLine(), out double v0);
            Console.WriteLine("R");
            Double.TryParse(Console.ReadLine(), out double R);
            Console.WriteLine("H");
            Double.TryParse(Console.ReadLine(), out double H);
            Console.WriteLine("P");
            Double.TryParse(Console.ReadLine(), out double P);

            var t = R / (v0 * Math.Cos(a));
            var y = R * Math.Tan(a) - 9.8 * Math.Pow(t, 2) / 2;
            Console.WriteLine((y >= H && y <= H + P));
        }
    }
}
