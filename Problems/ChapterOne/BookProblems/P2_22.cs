﻿using System;
using System.Linq;

namespace ChapterOne.BookProblems
{
    public class P2_22
    {
        public static void Resolve()
        {
            Console.WriteLine("Enter number");
            var number = Console.ReadLine().Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).ToList();
            Console.WriteLine($"Result: {number[number.Count - 2]}, {number[number.Count - 3]}");
        }
    }
}
