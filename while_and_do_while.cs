using System;

// while - check every condition before each iteration
int number = 1;
while (number <=5)
{
    Console.WriteLine($"Number: {number} ");
    number++;
}

// do-while - will execute at least once
int n = 10;
do
{
    Console.WriteLine($"n = {n}");
    n--;
} while (n > 8);

// break and continue
for (int i = 0; i < 10; i++)
{
    if (i == 3) continue; // skip 3
    if (i == 7) break; // stop at 7
    Console.Write($"{i} ");
}