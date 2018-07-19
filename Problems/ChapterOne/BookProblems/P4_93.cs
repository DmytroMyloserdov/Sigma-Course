using System;

namespace ChapterOne.BookProblems
{
    public class P4_93
    {
        public static void Resolve()
        {
            Console.WriteLine("Y");
            Double.TryParse(Console.ReadLine(), out double x);
            if(x < 2.5) { Console.WriteLine(3); }
            else if(x > 5) { Console.WriteLine(1); }
            else { Console.WriteLine(2); }
        }
    }
}
