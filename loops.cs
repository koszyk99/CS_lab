using System;

// for loop
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Iteration nr {i}");
}

// reverse loop
for (int i = 5; i > 0; i--)
{
    Console.WriteLine($"Reverse iteration nr {i}");
}

// sum of numbers 1-100
int sum = 0;
for (int i = 1; i <= 100; i++)
    sum += i;
Console.WriteLine($"Sum 1-100 = {sum}");