using ChapterOne.ArrayProblems;
using ChapterOne.BookProblems;
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
        struct ChapterOne
        {
            public ProblemDelegate[] ArrayProblemResolves;
            public ProblemDelegate[] BookProblemResolves;

            public ChapterOne(ProblemDelegate[] arrayProblemResolves, ProblemDelegate[] bookProblemResolves)
            {
                this.ArrayProblemResolves = arrayProblemResolves;
                this.BookProblemResolves = bookProblemResolves;
            }
        }

        static void Main(string[] args)
        {
            var chapterOneResolves = new ChapterOne(
                new ProblemDelegate[]
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
                }, 
                new ProblemDelegate[]
                {
                    new ProblemDelegate(P1_24.Resolve),
                    new ProblemDelegate(P2_12.Resolve),

                });

            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine($"---====PROBLEM 4_{i}====---");
                chapterOneResolves.ArrayProblemResolves[i - 1].Invoke();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
