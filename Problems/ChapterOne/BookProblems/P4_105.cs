using System;
using System.Collections.Generic;

namespace ChapterOne.BookProblems
{
    public class P4_105
    {
        public static void Resolve()
        {
            List<string> monthes = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine("index");
            Int32.TryParse(Console.ReadLine(), out int i);
            Console.WriteLine(monthes[i - 1]);
        }
    }
}
