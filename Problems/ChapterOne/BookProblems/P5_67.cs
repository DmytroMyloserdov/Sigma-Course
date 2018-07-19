using System;
using System.Text;

namespace ChapterOne.BookProblems
{
    public class P5_67
    {
        public static void Resolve()
        {
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);

            Console.WriteLine("k");
            Int32.TryParse(Console.ReadLine(), out int k);

            long[] array = new long[n > k + 1 ? n : k + 1];
            array[0] = 1;
            array[1] = 1;

            long sum = 2;
            StringBuilder strb = new StringBuilder();
            strb.Append("1,1");
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
                if (i < n)
                {
                    sum += array[i];
                    strb.Append($",{array[i]}");
                }
            }

            Console.WriteLine(array[k]);
            Console.WriteLine(strb.ToString());
            Console.WriteLine(sum % 2 == 0);
        }
    }
}
