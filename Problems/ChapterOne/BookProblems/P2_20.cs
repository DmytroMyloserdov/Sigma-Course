using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.BookProblems
{
    public class P2_20
    {
        static int[] _arr;
        static int[] array;
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine();
            Console.WriteLine("Result");
            Console.WriteLine(number.Reverse());
            array = number.Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).ToArray();
            _arr = array;
            Swap(1, 2);
            Swap(3, 4);
            Print();
            array = _arr;
            Swap(2, 3);
            Print();
            array = _arr;
            Swap(1, 3);
            Swap(2, 4);
            Print();
        }

        private static void Swap(int indexA, int indexB)
        {
            indexA--;
            indexB--;
            var temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;
        }

        private static void Print()
        {
            if (array[0] != 0)
            {
                Console.Write(array[0]);
            }
            for (int i = 1; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.Write("\n");
        }
    }
}
