using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_102
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter word");
            var s = Console.ReadLine().ToList();
            Console.WriteLine("Enter m");
            Int32.TryParse(Console.ReadLine(), out int m);
            Console.WriteLine("Enter n");
            Int32.TryParse(Console.ReadLine(), out int n);


            var tempM = (int)s[m - 1];
            var tempN = (int)s[n - 1];

            s[m - 1] = (char)tempN;
            s[n - 1] = (char)tempM;

            s.ForEach(c => Console.Write(c));
        }
    }
}
