using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class P4_8
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var arr = Console.ReadLine().Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList();
            var countOfZeros = arr.Count(c => c == 0);
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < countOfZeros; i++)
            {
                strb.Append("0 ");
            }
            arr.ForEach(c =>
            {
                if (c != 0) { strb.Append($"{c} "); }
            });
            Console.WriteLine($"Result: {strb.ToString()}");
        }
    }
}
