using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class P4_2
    {
        enum Dest
        {
            Left,
            Right
        }
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var arr = Console.ReadLine().Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList();
            var max = arr.Where(c => c % 2 != 0).Max();
            var maxIndex = arr.IndexOf(max);
            Console.WriteLine($"Result: {PrintList(Move(Dest.Right, 1, arr.GetRange(0, maxIndex)))}{max} {PrintList(Move(Dest.Left, 3, arr.GetRange(maxIndex + 1, arr.Count - maxIndex - 1)))}");
        }

        private static List<int> Move(Dest destination, int countOfMoves, List<int> list)
        {
            var newList = new List<int>();
            if (destination == Dest.Left)
            {
                var temp = list.GetRange(0, countOfMoves);
                list.RemoveRange(0, countOfMoves);
                list.AddRange(temp);
                return list;
            }
            else
            {
                var temp = list.GetRange(0, list.Count - countOfMoves);
                list.RemoveRange(0, list.Count - countOfMoves);
                list.AddRange(temp);
                return list;
            }
        }
        
        private static string PrintList(List<int> list)
        {
            StringBuilder strb = new StringBuilder();
            list.ForEach(c => strb.Append($"{c} "));
            return strb.ToString();
        }
    }
}
