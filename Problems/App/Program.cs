using ArrayProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        delegate void ProblemDelegate();

        static void Main(string[] args)
        {
            ProblemDelegate[] problemResolves = new ProblemDelegate[]
            {
                new ProblemDelegate(P4_1.Resolve),
                new ProblemDelegate(P4_2.Resolve),
                new ProblemDelegate(P4_3.Resolve),
                new ProblemDelegate(P4_4.Resolve),
                new ProblemDelegate(P4_5.Resolve),
                new ProblemDelegate(P4_6.Resolve),
                new ProblemDelegate(P4_7.Resolve),
                new ProblemDelegate(P4_8.Resolve),
                new ProblemDelegate(P4_9.Resolve),
                new ProblemDelegate(P4_10.Resolve),
                new ProblemDelegate(P4_11.Resolve)
            };

            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine($"---====PROBLEM 4_{i}====---");
                problemResolves[i - 1].Invoke();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
