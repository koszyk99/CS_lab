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