using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.ArrayProblems
{
    public class P4_7
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var arr = Console.ReadLine().Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList();
            if (arr.Count(c => c % 2 == 0) == 0)
            {
                Console.WriteLine($"Result: {arr[0]}");
                return;
            }

            var res = arr.Where(c => c % 2 == 0).Min();
            Console.WriteLine($"Result: {res}");
        }
    }
}
