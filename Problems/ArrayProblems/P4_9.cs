using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class P4_9
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var arr = Console.ReadLine().Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList();
            var maxVal = arr.Max();
            var minVal = arr.Min();
            long maxValIndex = -1, minValIndex = -1;
            for (int i = 0; i < arr.Count; i++)
            {
                if (maxValIndex == -1 && arr[i] == maxVal)
                {
                    maxValIndex = i;
                }
                if (minValIndex == -1 && arr[i] == minVal)
                {
                    minValIndex = i;
                }
            }

            Console.WriteLine($"Result: {maxValIndex + minValIndex}");
        }
    }
}
