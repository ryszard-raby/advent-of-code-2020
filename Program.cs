﻿using System;
using advent_of_code_2020.Days;
using advent_of_code_2020.Days.Day02;

namespace advent_of_code_2020 {
    class Program {
        static void Main(string[] args) => ShowDayResult(new Day02());

        static void ShowDayResult(Day day) {
            Console.WriteLine($"{day.GetType().Name}");
            Console.WriteLine($"Part 1: {day.FirstStar()}");
            Console.WriteLine($"Part 2: {day.SecondStar()}");
        }
    }
}
