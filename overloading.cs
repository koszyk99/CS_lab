using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(CalculateArea(5));
        Console.WriteLine(CalculateArea(4, 6));
        Console.WriteLine(CalculateArea(3, true));
    }

    static double CalculateArea(double side) => side * side;
    static double CalculateArea(double width, double height) => width * height;
    static double CalculateArea(double r, bool circle) => Math.PI * r * r;
}