using System;

string[] fruits = { "apple", "banana", "cherry", "mango" };

foreach (string fruit in fruits)
{
    Console.WriteLine($"Friut: {fruit}");
}

// string foreach - iteration by symbol
foreach (char c in "C# and C++")
{
    Console.Write($"[{c}]");
}