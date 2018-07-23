using System;
using System.Text;

namespace ChapterOne.BookProblems
{
    public class P9_49
    {
        public static void Resolve()
        {
            var s = Console.ReadLine();
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                strb.Append("*");
            }

            Console.WriteLine(strb.ToString() + s + strb.ToString());
        }
    }
}
