using System;
using System.Collections.Generic;
using System.Linq;

namespace StepikProblems
{
    public class BracketsInTheCode
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter input");
            var input = Console.ReadLine().ToList();
            Console.WriteLine(IsStackEmpty(out int res, input) ? "Success" : res.ToString());
        }

        private static bool IsStackEmpty(out int res, List<char> input)
        {
            res = 1;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Count; i++)
            {
                if (!"([{}])".Contains(input[i]))
                {
                    continue;
                }

                if ("([{".Contains(input[i]))
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (!stack.Any())
                    {
                        res += i;
                        return false;
                    }
                    var top = stack.Pop();
                    if ((top == '[' && input[i] != ']') ||
                        (top == '{' && input[i] != '}') ||
                        (top == '(' && input[i] != ')'))
                    {
                        res += i;
                        return false;
                    }
                }
            }
            return !stack.Any();
        }
    }
}
