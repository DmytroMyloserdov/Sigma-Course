using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.ArrayProblems
{
    public class P4_5
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var strInput = Console.ReadLine();
            if (strInput.Count(c => c == '0') < 2)
            {
                Console.WriteLine("Result: 0");
                return;
            }

            var startIndex = strInput.IndexOf('0');
            strInput = strInput.Remove(startIndex, 1);
            var endIndex = strInput.IndexOf('0');
            strInput = strInput.Remove(startIndex, 1);

            var array = strInput.Substring(startIndex, endIndex - startIndex).Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList();
            var res = 0;
            array.ForEach(c => res += c);
            Console.WriteLine($"Result: {res}");
        }
    }
}
