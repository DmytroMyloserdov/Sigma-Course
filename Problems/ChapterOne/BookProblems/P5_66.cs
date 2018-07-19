using System;

namespace ChapterOne.BookProblems
{
    public class P5_66
    {
        public static void Resolve()
        {
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);

            double[] array = new double[n + 1];
            array[0] = 1;

            for (int i = 1; i < n + 1; i++)
            {
                array[i] = i * array[i - 1] + 1 / i;
            }
            Console.WriteLine(array[n]);
        }
    }
}
