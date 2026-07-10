using System;

// declare and initialize
int[] grades = { 5, 4, 3, 5, 4 };

// access by index (of !0)
Console.WriteLine(grades[0]); // 5 - first element
Console.WriteLine(grades[4]); // 4 - last element
Console.WriteLine(grades[^1]); // 4 - last (C# 8 syntax)

// board lenght
Console.WriteLine(grades.Length); // 5

// modify
grades[2] = 5;

// sort
Array.Sort(grades);
Console.WriteLine(string.Join(", ", grades)); // 4, 4, 5, 5, 5

// search
int index = Array.IndexOf(grades, 4); // 0

// 2D board
int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 }
};
Console.WriteLine(matrix[1, 2]); // 6 (row 1, column 2)