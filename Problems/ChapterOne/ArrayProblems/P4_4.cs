using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.ArrayProblems
{
    public class P4_4
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var arr = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToList();
            long res = 1;
            for (int i = 1; i < arr.Count; i += 2)
            {
                res *= arr[i];
            }
            Console.WriteLine($"Result: {res}");
        }
    }
}
