using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.BookProblems
{
    public class P8_2
    {
        public static void Resolve()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("5 ");
                }
                Console.Write("\n");
            }

            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("5 ");
                }
                Console.Write("\n");
            }
        }
    }
}
