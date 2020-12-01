﻿using System;
using advent_of_code_2020.Days;
using advent_of_code_2020.Days.Day01;

namespace advent_of_code_2020 {
    class Program {
        static void Main(string[] args) => ShowDayResult(new Day01());

        static void ShowDayResult(Day day) {
            Console.WriteLine(day.FirstStar());
            Console.WriteLine(day.SecondStar());
        }
    }
}
