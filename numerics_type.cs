using System;
class Program
{
    static void Main(string[] args)
    {
        // numeric types
        int quantity = 10;
        decimal price = 49.99M; // M = suffix for decimal
        long bigNumber = 9_000_000_000L; // underscore for readability
        double pi = 3.14159;

        decimal sum = quantity * price;
        Console.WriteLine($"Sum: {sum:C}"); // :C = currency format
    }
}