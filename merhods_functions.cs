using System;

// syntax - modifier return_type method_name(parameter)

// method without parameter and without return value (void)
static void Grettings()
{
    Console.WriteLine("Hello in program");
}

// method with parameter
static void GrettingsPerson(string name, int age)
{
    Console.WriteLine($"Hello {name}, you have {age} years old");
}

// value returning method
static int Addition(int a, int b)
{
    return a + b;
}

// invocation
Grettings();
GrettingsPerson("Krzysztof", 25);
int result = Addition(10, 20);
Console.WriteLine(result);