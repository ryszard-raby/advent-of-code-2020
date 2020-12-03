﻿using System.IO;

namespace advent_of_code_2020.Days {
    public abstract class Day : IDay {
        private string[] _inputLines;
        public string[] InputLines => _inputLines ??= File.ReadAllLines($"../../../Days/{GetType().Name}/input.txt");
        public abstract object FirstStar();
        public abstract object SecondStar();
    }
}
