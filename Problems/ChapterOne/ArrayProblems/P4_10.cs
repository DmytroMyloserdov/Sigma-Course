using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.ArrayProblems
{
    public class P4_10
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var arr = Console.ReadLine().Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList();
            Console.WriteLine("Enter value");
            Int32.TryParse(Console.ReadLine(), out int value);
            long[,] intervals = new long[arr.Count, arr.Count];
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        intervals[i, j] += arr[k];
                    }
                }
            }

            StringBuilder strb = new StringBuilder();
            strb.Append("Result: ");
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (intervals[i, j] == value)
                    {
                        strb.Append($"({i};{j}), ");
                    }
                }
            }
            Console.WriteLine(strb.ToString());
        }
    }
}
