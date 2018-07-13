using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class P4_1
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            SortedSet<int> set = new SortedSet<int>();
            var arr = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToList();
            arr.ForEach(c => set.Add(c));
            Console.Write("Result: ");
            foreach (var c in set)
            {
                Console.Write($"{ c } ");
            }
        }
    }
}
