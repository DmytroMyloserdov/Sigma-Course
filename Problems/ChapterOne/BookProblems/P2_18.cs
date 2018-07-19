using System;
using System.Linq;
using System.Text;

namespace ChapterOne.BookProblems
{
    public class P2_18
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine().Split().ToList();
            Console.WriteLine("Result:");
            for (int i = 0; i < 3; i++)
            {
                StringBuilder strb = new StringBuilder();
                strb.Append(number[i]);
                StringBuilder temp = new StringBuilder();
                for (int j = 0; j < 3 && j != i; j++)
                {
                    temp.Append(number[j]);
                }
                strb.Append(temp.ToString());
                Console.WriteLine(strb.ToString());
                strb.Remove(1, 2);
                strb.Append(temp.ToString().Reverse());
                Console.WriteLine(strb.ToString());
            }
        }
    }
}
