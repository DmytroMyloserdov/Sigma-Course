using System;
using System.Collections.Generic;
using System.Linq;

namespace StepikProblems
{
    public class HeightOfTree
    {
        public static void Resolve()
        {
            Int32.TryParse(Console.ReadLine(), out int n);
            SortedSet<int> set = new SortedSet<int>();
            Console.ReadLine().Split(' ').ToList().ForEach(c => set.Add(Convert.ToInt32(c)));
            Console.WriteLine(set.Count);
        }
    }
}
