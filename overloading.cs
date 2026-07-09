using System;

// compiler choose right version
static double CalculateArea(double side) // square
    => side * side;

static double CalculateArea(double width, double height) // rectangle
    => width * height;

static double CalculateArea(double r, bool circle) // circle
    => Math.PI * r * r;

Console.WriteLine(CalculateArea(5));
Console.WriteLine(CalculateArea(4, 6));
Console.WriteLine(CalculateArea(3, true));