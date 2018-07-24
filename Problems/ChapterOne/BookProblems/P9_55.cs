using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P9_55
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter 2 symbols separated by whitespace");
            var symbols = Console.ReadLine();
            symbols = symbols.Remove(symbols.IndexOf(' '), 1);
            var symbolList = symbols.ToList();
            Console.WriteLine("Sentense");
            Console.ReadLine().ToList().ForEach(c =>
            {
                if (c == symbols[0] || c == symbols[1])
                {
                    Console.WriteLine(c);
                }
            });
        }
    }
}
