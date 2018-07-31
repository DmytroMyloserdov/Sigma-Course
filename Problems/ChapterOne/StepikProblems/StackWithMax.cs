using System;
using System.Collections.Generic;
using System.Linq;

namespace StepikProblems
{
    public class StackWithMax
    {
        public class MyStack<T> where T : IComparable
        {
            Stack<T> MaxValues { get; set; }
            Stack<T> Values { get; set; }

            public MyStack()
            {
                MaxValues = new Stack<T>();
                Values = new Stack<T>();
            }

            public void Push(T value)
            {
                Values.Push(value);
                MaxValues.Push((!MaxValues.Any() || value.CompareTo(MaxValues.Peek()) > 0) ? value : MaxValues.Peek());
            }

            public void Pop()
            {
                Values.Pop();
                MaxValues.Pop();
            }

            public T Max()
            {
                return MaxValues.Peek();
            }
        }

        public static void Resolve()
        {
            Int32.TryParse(Console.ReadLine(), out int q);
            MyStack<int> stack = new MyStack<int>();
            string[][] commands = new string[q][];
            for (int i = 0; i < q; i++)
            {
                commands[i] = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < q; i++)
            {
                switch (commands[i][0])
                {
                    case "push":
                        Int32.TryParse(commands[i][1], out int n);
                        stack.Push(n);
                        break;
                    case "pop":
                        stack.Pop();
                        break;
                    case "max":
                        Console.WriteLine(stack.Max());
                        break;
                }
            }
        }
    }
}
