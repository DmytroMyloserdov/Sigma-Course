using System;
using System.Text;

namespace ChapterOne.BookProblems
{
    public class P8_1
    {
        public static void Resolve()
        {
            StringBuilder strb = new StringBuilder();
            for (int j = 0; j < 6; j++)
            {
                strb.Append("5 ");
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(strb.ToString());
            }

            Console.WriteLine();
            strb.Clear();
            for(int i = 1; i <= 10; i++)
            {
                strb.Append(i + " ");
            }

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(strb.ToString());
            }

            Console.WriteLine();
            strb.Clear();

            for (int i = 41; i <= 80; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
