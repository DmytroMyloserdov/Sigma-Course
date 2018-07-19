using System;

namespace ChapterOne.BookProblems
{
    public class P4_85
    {
        public static void Resolve()
        {
            Console.WriteLine("X");
            Double.TryParse(Console.ReadLine(), out double x);
            if (x < -1)
            {
                Console.WriteLine(1);
            }
            else if(x > -1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
