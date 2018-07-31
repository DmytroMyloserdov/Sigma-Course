using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepikProblems
{
    public class MaxInWindow
    {
        public class MyQueue<T> where T : IComparable
        {
            public Queue<T> Values { get; set; }
            public List<T> MaxValues { get; set; }
            public int Length
            {
                get
                {
                    return Values.Count;
                }
            }

            public MyQueue()
            {
                Values = new Queue<T>();
                MaxValues = new List<T>();
            }

            public void Enqueue(T item)
            {
                Values.Enqueue(item);
                MaxValues.Add(item);

                for (var i = MaxValues.Count - 2; i >= 0 && MaxValues[i].CompareTo(item) < 0; i--) 
                {
                    MaxValues[i] = item;
                }
            }

            public void Dequeue()
            {
                Values.Dequeue();
                MaxValues.RemoveAt(0);
            }

            public T Max()
            {
                return MaxValues[0];
            }
        }

        public static void Resolve()
        {
            Int32.TryParse(Console.ReadLine(), out int n);
            var numbers = Console.ReadLine().Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList();
            Int32.TryParse(Console.ReadLine(), out int m);

            Stack<int> satck = new Stack<int>();
            satck.Push(2);
            satck.Push(3);
            satck.Reverse();
            var myQueue = new MyQueue<int>();

            for (int i = 0; i < n; i++)
            {
                if (myQueue.Length == m)
                {
                    Console.Write(myQueue.Max() + " ");
                    myQueue.Dequeue();
                }
                myQueue.Enqueue(numbers[i]);
            }
            Console.Write(myQueue.Max());
        }
    }
}
