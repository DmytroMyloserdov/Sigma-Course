using System;
using System.Text;

namespace ChapterOne.BookProblems
{
    public class P6_10
    {
        public static void Resolve()
        {
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);

            StringBuilder strb = new StringBuilder();
            int i = 0;
            for (i = 0; i * i < n; i++)
            {
                strb.Append(i + " ");
            }
            Console.WriteLine(strb.ToString());
            Console.WriteLine(i);
        }
    }
}
