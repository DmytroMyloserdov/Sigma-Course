using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.BookProblems
{
    public class P2_12
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine().Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).ToList();
            var mult = 1;
            number.ForEach(c => mult *= c);
            Console.WriteLine($"Result:\n\ta){number[2]}\n\tb){number[1]}\n\tc){number.Sum()}\n\td){mult}");
        }
    }
}
