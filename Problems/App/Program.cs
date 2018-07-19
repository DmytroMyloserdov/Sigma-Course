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
        struct ChapterOneProblems
        {
            public ProblemDelegate[] ArrayProblemResolves;
            public ProblemDelegate[] BookProblemResolves;
            public List<string> BookNumbers;

            public ChapterOneProblems(ProblemDelegate[] arrayProblemResolves, ProblemDelegate[] bookProblemResolves, List<string> bookBNumbers)
            {
                ArrayProblemResolves = arrayProblemResolves;
                BookProblemResolves = bookProblemResolves;
                BookNumbers = bookBNumbers;
            }
        }

        static void Main(string[] args)
        {
            var chapterOneResolves = new ChapterOneProblems(
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
                    new ProblemDelegate(P2_13.Resolve),
                    new ProblemDelegate(P2_14.Resolve),
                    new ProblemDelegate(P2_15.Resolve),
                    new ProblemDelegate(P2_16.Resolve),
                    new ProblemDelegate(P2_17.Resolve),
                    new ProblemDelegate(P2_18.Resolve),
                    new ProblemDelegate(P2_19.Resolve),
                    new ProblemDelegate(P2_20.Resolve),
                    new ProblemDelegate(P2_21.Resolve),
                    new ProblemDelegate(P2_22.Resolve),
                    new ProblemDelegate(P2_23.Resolve),
                    new ProblemDelegate(P3_32.Resolve),
                    new ProblemDelegate(P3_33.Resolve),
                    //new ProblemDelegate(ChapterOne.BookProblems.P4_1.Resolve),
                    //new ProblemDelegate(ChapterOne.BookProblems.P4_2.Resolve),
                    //new ProblemDelegate(ChapterOne.BookProblems.P4_3.Resolve),
                    //new ProblemDelegate(ChapterOne.BookProblems.P4_4.Resolve),
                    //new ProblemDelegate(ChapterOne.BookProblems.P4_5.Resolve),
                },
                new List<string>()
                {
                    "P1_24",
                    "P2_12",
                    "P2_13",
                    "P2_14",
                    "P2_15",
                    "P2_16",
                    "P2_17",
                    "P2_18",
                    "P2_19",
                    "P2_20",
                    "P2_21",
                    "P2_22",
                    "P2_23",
                    "P3_32",
                    "P3_33",
                    "P4_1",
                    "P4_2",
                    "P4_3",
                    "P4_4",
                    "P4_5",
                });

            //for (int i = 1; i <= 11; i++)
            //{
            //    Console.WriteLine($"---====PROBLEM 4_{i}====---");
            //    chapterOneResolves.ArrayProblemResolves[i - 1].Invoke();
            //    Console.ReadLine();
            //    Console.Clear();
            //}

            for (int i = 0; i < chapterOneResolves.BookNumbers.Count; i++)
            {
                Console.WriteLine($"---====PROBLEM {chapterOneResolves.BookNumbers[i]}====---");
                chapterOneResolves.BookProblemResolves[i].Invoke();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
