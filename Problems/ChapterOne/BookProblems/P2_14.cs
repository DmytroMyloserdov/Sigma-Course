using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.BookProblems
{
    public class P2_14
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine().Split().ToList();
            number.Add(number[0]);
            number.RemoveAt(0);
            Console.Write("Result: ");
            number.ForEach(c => Console.Write(c));
        }
    }
}
