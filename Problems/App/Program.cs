using ChapterOne.ArrayProblems;
using ChapterOne.BookProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OwnListBasedOnArray;
using SortingAlgorithms;
using StepikProblems;

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
            public ProblemDelegate[] StepikProblems;
            public List<string> StepikNames;

            public ChapterOneProblems(
                ProblemDelegate[] arrayProblemResolves,
                ProblemDelegate[] bookProblemResolves,
                List<string> bookBNumbers,
                ProblemDelegate[] stepikProblems,
                List<string> stepikNames)
            {
                ArrayProblemResolves = arrayProblemResolves;
                BookProblemResolves = bookProblemResolves;
                BookNumbers = bookBNumbers;
                StepikProblems = stepikProblems;
                StepikNames = stepikNames;
            }
        }

        static void Main(string[] args)
        {
            var chapterOneResolves = new ChapterOneProblems(
                new ProblemDelegate[]
                {
                        new ProblemDelegate(ChapterOne.ArrayProblems.P4_1.Resolve),
                        new ProblemDelegate(ChapterOne.ArrayProblems.P4_2.Resolve),
                        new ProblemDelegate(ChapterOne.ArrayProblems.P4_3.Resolve),
                        new ProblemDelegate(ChapterOne.ArrayProblems.P4_4.Resolve),
                        new ProblemDelegate(ChapterOne.ArrayProblems.P4_5.Resolve),
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
                        new ProblemDelegate(ChapterOne.BookProblems.P4_1.Resolve),
                        new ProblemDelegate(ChapterOne.BookProblems.P4_2.Resolve),
                        new ProblemDelegate(ChapterOne.BookProblems.P4_3.Resolve),
                        new ProblemDelegate(ChapterOne.BookProblems.P4_4.Resolve),
                        new ProblemDelegate(ChapterOne.BookProblems.P4_5.Resolve),
                        new ProblemDelegate(P4_37.Resolve),
                        new ProblemDelegate(P4_38.Resolve),
                        new ProblemDelegate(P4_39.Resolve),
                        new ProblemDelegate(P4_40.Resolve),
                        new ProblemDelegate(P4_41.Resolve),
                        new ProblemDelegate(P4_42.Resolve),
                        new ProblemDelegate(P4_68.Resolve),
                        new ProblemDelegate(P4_85.Resolve),
                        new ProblemDelegate(P4_86.Resolve),
                        new ProblemDelegate(P4_87.Resolve),
                        new ProblemDelegate(P4_88.Resolve),
                        new ProblemDelegate(P4_89.Resolve),
                        new ProblemDelegate(P4_90.Resolve),
                        new ProblemDelegate(P4_91.Resolve),
                        new ProblemDelegate(P4_92.Resolve),
                        new ProblemDelegate(P4_93.Resolve),
                        new ProblemDelegate(P4_104.Resolve),
                        new ProblemDelegate(P4_105.Resolve),
                        new ProblemDelegate(P4_106.Resolve),
                        new ProblemDelegate(P4_107.Resolve),
                        new ProblemDelegate(P5_13.Resolve),
                        new ProblemDelegate(P5_14.Resolve),
                        new ProblemDelegate(P5_15.Resolve),
                        new ProblemDelegate(P5_27.Resolve),
                        new ProblemDelegate(P5_28.Resolve),
                        new ProblemDelegate(P5_29.Resolve),
                        new ProblemDelegate(P5_30.Resolve),
                        new ProblemDelegate(P5_31.Resolve),
                        new ProblemDelegate(P5_32.Resolve),
                        new ProblemDelegate(P5_33.Resolve),
                        new ProblemDelegate(P5_34.Resolve),
                        new ProblemDelegate(P5_35.Resolve),
                        new ProblemDelegate(P5_36.Resolve),
                        new ProblemDelegate(P5_37.Resolve),
                        new ProblemDelegate(P5_40.Resolve),
                        new ProblemDelegate(P5_41.Resolve),
                        new ProblemDelegate(P5_66.Resolve),
                        new ProblemDelegate(P5_67.Resolve),
                        new ProblemDelegate(P5_68.Resolve),
                        new ProblemDelegate(P5_81.Resolve),
                        new ProblemDelegate(P5_82.Resolve),
                        new ProblemDelegate(P5_83.Resolve),
                        new ProblemDelegate(P6_10.Resolve),
                        new ProblemDelegate(P6_11.Resolve),
                        new ProblemDelegate(P6_12.Resolve),
                        new ProblemDelegate(P6_33.Resolve),
                        new ProblemDelegate(P6_91.Resolve),
                        new ProblemDelegate(P8_1.Resolve),
                        new ProblemDelegate(P8_2.Resolve),
                        new ProblemDelegate(P8_3.Resolve),
                        new ProblemDelegate(P8_4.Resolve),
                        new ProblemDelegate(P8_5.Resolve),
                        new ProblemDelegate(P8_6.Resolve),
                        new ProblemDelegate(P8_7.Resolve),
                        new ProblemDelegate(P8_8.Resolve),
                        new ProblemDelegate(P8_36.Resolve),
                        new ProblemDelegate(P9_41.Resolve),
                        new ProblemDelegate(P9_42.Resolve),
                        new ProblemDelegate(P9_43.Resolve),
                        new ProblemDelegate(P9_44.Resolve),
                        new ProblemDelegate(P9_45.Resolve),
                        new ProblemDelegate(P9_46.Resolve),
                        new ProblemDelegate(P9_47.Resolve),
                        new ProblemDelegate(P9_48.Resolve),
                        new ProblemDelegate(P9_49.Resolve),
                        new ProblemDelegate(P9_50.Resolve),
                        new ProblemDelegate(P9_51.Resolve),
                        new ProblemDelegate(P9_52.Resolve),
                        new ProblemDelegate(P9_53.Resolve),
                        new ProblemDelegate(P9_54.Resolve),
                        new ProblemDelegate(P9_55.Resolve),
                        new ProblemDelegate(P9_56.Resolve),
                        new ProblemDelegate(P9_57.Resolve),
                        new ProblemDelegate(P9_58.Resolve),
                        new ProblemDelegate(P9_59.Resolve),
                        new ProblemDelegate(P9_60.Resolve),
                        new ProblemDelegate(P9_61.Resolve),
                        new ProblemDelegate(P9_62.Resolve),
                        new ProblemDelegate(P9_63.Resolve),
                        new ProblemDelegate(P9_64.Resolve),
                        new ProblemDelegate(P9_65.Resolve),
                        new ProblemDelegate(P9_66.Resolve),
                        new ProblemDelegate(P9_67.Resolve),
                        new ProblemDelegate(P9_68.Resolve),
                        new ProblemDelegate(P9_69.Resolve),
                        new ProblemDelegate(P9_70.Resolve),
                        new ProblemDelegate(P9_71.Resolve),
                        new ProblemDelegate(P9_72.Resolve),
                        new ProblemDelegate(P9_73.Resolve),
                        new ProblemDelegate(P9_74.Resolve),
                        new ProblemDelegate(P9_75.Resolve),
                        new ProblemDelegate(P9_76.Resolve),
                        new ProblemDelegate(P9_77.Resolve),
                        new ProblemDelegate(P9_78.Resolve),
                        new ProblemDelegate(P9_90.Resolve),
                        new ProblemDelegate(P9_91.Resolve),
                        new ProblemDelegate(P9_92.Resolve),
                        new ProblemDelegate(P9_93.Resolve),
                        new ProblemDelegate(P9_94.Resolve),
                        new ProblemDelegate(P9_95.Resolve),
                        new ProblemDelegate(P9_96.Resolve),
                        new ProblemDelegate(P9_97.Resolve),
                        new ProblemDelegate(P9_98.Resolve),
                        new ProblemDelegate(P9_99.Resolve),
                        new ProblemDelegate(P9_100.Resolve),
                        new ProblemDelegate(P9_101.Resolve),
                        new ProblemDelegate(P9_102.Resolve),
                        new ProblemDelegate(P9_103.Resolve),
                        new ProblemDelegate(P9_104.Resolve),
                        new ProblemDelegate(P9_138.Resolve),
                        new ProblemDelegate(P9_139.Resolve),
                        new ProblemDelegate(P9_140.Resolve),
                        new ProblemDelegate(P9_141.Resolve),
                        new ProblemDelegate(P9_142.Resolve),
                        new ProblemDelegate(P9_143.Resolve),
                        new ProblemDelegate(P9_152.Resolve),
                        new ProblemDelegate(P9_153.Resolve),
                        new ProblemDelegate(P9_154.Resolve),
                        new ProblemDelegate(P9_155.Resolve)
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
                        "P4_37",
                        "P4_38",
                        "P4_39",
                        "P4_40",
                        "P4_41",
                        "P4_42",
                        "P4_68",
                        "P4_85",
                        "P4_86",
                        "P4_87",
                        "P4_88",
                        "P4_89",
                        "P4_90",
                        "P4_91",
                        "P4_92",
                        "P4_93",
                        "P4_104",
                        "P4_105",
                        "P4_106",
                        "P4_107",
                        "P5_13",
                        "P5_14",
                        "P5_15",
                        "P5_27",
                        "P5_28",
                        "P5_29",
                        "P5_30",
                        "P5_31",
                        "P5_32",
                        "P5_33",
                        "P5_34",
                        "P5_35",
                        "P5_36",
                        "P5_37",
                        "P5_40",
                        "P5_41",
                        "P5_66",
                        "P5_67",
                        "P5_68",
                        "P5_81",
                        "P5_82",
                        "P5_83",
                        "P6_10",
                        "P6_11",
                        "P6_12",
                        "P6_33",
                        "P6_91",
                        "P8_1",
                        "P8_2",
                        "P8_3",
                        "P8_4",
                        "P8_5",
                        "P8_6",
                        "P8_7",
                        "P8_8",
                        "P8_36",
                        "P9_41",
                        "P9_42",
                        "P9_43",
                        "P9_44",
                        "P9_45",
                        "P9_46",
                        "P9_47",
                        "P9_48",
                        "P9_49",
                        "P9_50",
                        "P9_51",
                        "P9_52",
                        "P9_53",
                        "P9_54",
                        "P9_55",
                        "P9_56",
                        "P9_57",
                        "P9_58",
                        "P9_59",
                        "P9_60",
                        "P9_61",
                        "P9_62",
                        "P9_63",
                        "P9_64",
                        "P9_65",
                        "P9_66",
                        "P9_67",
                        "P9_68",
                        "P9_69",
                        "P9_70",
                        "P9_71",
                        "P9_72",
                        "P9_73",
                        "P9_74",
                        "P9_75",
                        "P9_76",
                        "P9_77",
                        "P9_78",
                        "P9_90",
                        "P9_91",
                        "P9_92",
                        "P9_93",
                        "P9_94",
                        "P9_95",
                        "P9_96",
                        "P9_97",
                        "P9_98",
                        "P9_99",
                        "P9_100",
                        "P9_101",
                        "P9_102",
                        "P9_103",
                        "P9_104",
                        "P9_138",
                        "P9_139",
                        "P9_140",
                        "P9_141",
                        "P9_142",
                        "P9_143",
                        "P9_152",
                        "P9_153",
                        "P9_154",
                        "P9_155",
                },
                new ProblemDelegate[]
                {
                    new ProblemDelegate(BracketsInTheCode.Resolve),
                    new ProblemDelegate(HeightOfTree.Resolve),
                    new ProblemDelegate(DurationOfWebPackages.Resolve),
                    new ProblemDelegate(StackWithMax.Resolve),
                    new ProblemDelegate(MaxInWindow.Resolve)

                },
                new List<string>()
                {
                    "Brackets In The Code",
                    "Height Of Tree",
                    "Duration Of Web Packages",
                    "Stack With Max",
                    "Max In Window"
                });

            while (true)
            {
                Console.WriteLine("Choose(print number):\n\t1.Array problems\n\t2.Book problems\n\t3.Sorting algorithms\n\t4.Stepik problems");
                Int32.TryParse(Console.ReadLine(), out int dest);
                switch (dest)
                {
                    case 1:
                        for (int i = 1; i <= 11; i++)
                        {
                            Console.WriteLine($"---====PROBLEM 4_{i}====---");
                            chapterOneResolves.ArrayProblemResolves[i - 1].Invoke();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        for (int i = 0; i < chapterOneResolves.BookNumbers.Count; i++)
                        {
                            Console.WriteLine($"---====PROBLEM {chapterOneResolves.BookNumbers[i]}====---");
                            chapterOneResolves.BookProblemResolves[i].Invoke();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        int[] randomNumbers = new int[] { 5, 56, 21, 4, 8, 3, 52, 69, 85, -54, 32, 51, -84, -67, 105, 8435, 5712, -956, 578, 153, 984 };
                        Console.WriteLine($"Default array { Algorithms<int>.ToString(randomNumbers) }");
                        Console.WriteLine($"Selection Sort: { Algorithms<int>.ToString(Algorithms<int>.SelectionSort(randomNumbers)) }");
                        Console.WriteLine($"Insertion Sort: { Algorithms<int>.ToString(Algorithms<int>.InsertionSort(randomNumbers)) }");
                        Console.WriteLine($"Bubble Sort: { Algorithms<int>.ToString(Algorithms<int>.BubbleSort(randomNumbers)) }");
                        Console.WriteLine($"Piramid Sort: { Algorithms<int>.ToString(Algorithms<int>.PiramidSort(randomNumbers)) }");
                        Console.WriteLine($"Merge Sort: { Algorithms<int>.ToString(Algorithms<int>.MergeSort(randomNumbers)) }");
                        Console.WriteLine($"Quick Sort: { Algorithms<int>.ToString(Algorithms<int>.QuickSort(randomNumbers)) }");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        for (int i = 0; i < chapterOneResolves.StepikNames.Count; i++)
                        {
                            Console.WriteLine($"---===={chapterOneResolves.StepikNames[i]}====---");
                            chapterOneResolves.StepikProblems[4].Invoke();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                }

            }
        }
    }
}
